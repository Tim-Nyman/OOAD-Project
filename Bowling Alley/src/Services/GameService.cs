using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Alley.src
{
    public class GameService
    {
        public void Game()
        {
            ConsoleLogger logger = new();
            PlayerFactory playerFactory = new();
            int playerCount = 0;

            logger.Log("Välkommen till Fantasi Bowling!\n1 för att starta nytt spel\n2 för att se highscore\n3 för att avsluta\n");
            Console.Write("Val: ");

            var userInput = Console.ReadLine();
            bool continueLoop = true;

            do
            {
                if (userInput == "1")
                {
                    List<Player> players = new();
                    do
                    {
                        logger.Log("Skriv in namn: ");
                        var name = Console.ReadLine();

                        Player player = playerFactory.CreatePlayer(name);
                        players.Add(player);
                        logger.Log($"Spelare {name} har skapats\n");
                        playerCount += 1;

                    } while (playerCount < 2);

                    GameLogic gameLogic = new();
                    AddPlayerToDb addPlayerToDb = new();
                    addPlayerToDb.Add(players);

                    gameLogic.StartGame(players, logger);
                    continueLoop = false;
                }

                else if (userInput == "2")
                {
                    DataContext dataContext = DataContext.Instance;
                    HighscoreService highscoreService = new(dataContext);
                    var topPlayers = highscoreService.GetHighscore(3);

                    logger.Log("Topp 3 spelare\n____________________________");
                    Console.WriteLine("");
                    foreach (var player in topPlayers)
                    {
                        logger.Log($"{player.Username} - {player.Wins} vinster");
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("____________________________\n\n");
                    Console.ResetColor();


                    logger.Log("Gör ett val\n1 för att starta nytt spel\n2 för att se highscore\n3 för att avsluta");
                    Console.Write("\nVal: ");

                    userInput = Console.ReadLine();

                    if (userInput == "3")
                    {
                        continueLoop = false;
                    }
                }

                else if (userInput == "3")
                {
                    logger.Log("Spelet avslutas...\nSes en annan gång!");
                    return;
                }

                else
                {
                    logger.Log("Ogiltig inmatning");
                }
            } while (continueLoop == true);
        }
    }
}