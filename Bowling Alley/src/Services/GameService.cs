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

            logger.Log("Välkommen till Fantasi Bowling!\nTryck 1 för att starta nytt spel eller 2 för att avsluta.");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                List<Player> players = new();
                do
                {
                    logger.Log("Skriv in namn: ");
                    var name = Console.ReadLine();

                    Player player = playerFactory.CreatePlayer(name);
                    players.Add(player);
                    logger.Log($"Spelare {name} har skapats");

                    logger.Log("Vill du lägga till flera spelare? (Ja/Nej)");
                    userInput = Console.ReadLine();

                } while (userInput.ToLower() != "nej");

                GameLogic gameLogic = new();
                AddPlayerToDb addPlayerToDb = new();
                addPlayerToDb.Add(players);

                gameLogic.StartGame(players, logger);
            }

            else if (userInput == "2")
            {
                return;
            }

            else
            {
                logger.Log("Ogiltig inmatning");
            }
        }
    }
}