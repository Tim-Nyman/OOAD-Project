using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Alley.src
{
    public class GameLogic
    {
        private readonly Random _random = new();

        public int GenerateRandomScore()
        {
            return _random.Next(0, 10);
        }

        public void AddPointToWinner(int playerId)
        {
            var dbConn = DataContext.Instance;
            dbConn.AddWinsToPlayer(playerId);
        }

        public void StartGame(List<Player> players, ConsoleLogger logger)
        {
            string continueGame;

            if (players == null || players.Count == 0)
            {
                logger.Log("Ingen spelare tillagd.");
                return;
            }

            do
            {
                foreach (var player in players)
                {
                    player.Score = 0;
                    int score = GenerateRandomScore();
                    player.AddScore(score);
                    LogPlayerScore(player, score, logger);
                }

                int maxScore = players.Max(p => p.Score);
                var winners = players.Where(p => p.Score == maxScore).ToList();

                if (winners.Any())
                {
                    foreach (var winner in winners)
                    {
                        winner.IncrementWins();
                        logger.Log($"Spelare {winner.Username} vann med {winner.Score} poäng!\n");
                    }
                }
                else
                {
                    logger.Log("Ingen spelare vann.");
                }

                do
                {
                    logger.Log("Vill du spela igen? (Ja/Nej)");
                    continueGame = Console.ReadLine()?.Trim().ToLower();

                    if (continueGame != "ja" && continueGame != "nej")
                    {
                        logger.Log("Ogiltig inmatning, försök igen!\n");
                    }

                } while (continueGame != "ja" && continueGame != "nej");

            } while (continueGame.ToLower() != "nej");
        }

        private void LogPlayerScore(Player player, int score, ConsoleLogger logger)
        {        
            logger.Log($"{player.Username} fick {score} poäng!");
        }
    }
}