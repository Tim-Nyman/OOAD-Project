namespace Bowling_Alley.src
{
    public class PlayerFactory
    {
        public Player CreatePlayer(string username)
        {
            return new Player(username);
        }
    }
}