using System.ComponentModel.DataAnnotations;

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
    }
}