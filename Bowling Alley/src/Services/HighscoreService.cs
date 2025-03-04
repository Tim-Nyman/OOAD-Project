using Bowling_Alley.src;

public class HighscoreService
{
    private readonly DataContext _dataContext;

    public HighscoreService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public List<Player> GetHighscore(int topPlayers)
    {
        var players = _dataContext.GetPlayers();
        return players.OrderByDescending(p => p.Wins)
                      .Take(topPlayers)
                      .ToList();
    }
}