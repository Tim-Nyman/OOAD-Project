using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Alley.src
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public int Wins { get; set; }

        public Player(string username)
        {
            Username = username;
            Score = 0;
            Wins = 0;
        }

        public void AddScore(int points)
        {
            Score += points;
        }

        public void IncrementWins()
        {
            Wins++;
        }
    }
}