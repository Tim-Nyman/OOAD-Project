namespace Bowling_Alley.src
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[LOG]: {message}");
            Console.ResetColor();
        }
    }
}