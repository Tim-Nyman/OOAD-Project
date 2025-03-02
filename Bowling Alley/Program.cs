using Bowling_Alley.src;

class Program
{
    static void Main(string[] args)
    {
        GameService gameService = new();
        gameService.Game();
    }
}
