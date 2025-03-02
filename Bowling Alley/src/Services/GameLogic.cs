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
            return _random.Next(0, 100);
        }

        public void StartGame(List<Player> players, ConsoleLogger logger)
        {
            if (players == null || players.Count == 0)
            {
                logger.Log("Ingen spelare tillagd.");
                return;
            }

            foreach (var player in players)
            {
                int score = GenerateRandomScore();
                player.AddScore(score);
                LogPlayerScore(player, score, logger);
            }

            var winner = players.MaxBy(p => p.Score);

            if (winner != null)
            {
                logger.Log($"Spelare {winner.Username} vann med {winner.Score} poäng!");                
            }
            else
            {
                logger.Log("Ingen spelare vann.");
            }
        }

        private void LogPlayerScore(Player player, int score, ConsoleLogger logger)
        {
            logger.Log($"{player.Username} fick {score} poäng!");
        }
    }
}