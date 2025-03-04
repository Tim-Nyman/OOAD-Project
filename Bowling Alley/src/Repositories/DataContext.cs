using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bowling_Alley.src
{
    public sealed class DataContext
    {
        private static readonly Lazy<DataContext> _instance = new(() => new DataContext());
        private readonly AppDbContext _dbContext;

        private DataContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer("Data Source=DESKTOP-OB8A5A7;Initial Catalog=InlUppgift;Integrated Security=SSPI;TrustServerCertificate=True;").Options;
                    
            _dbContext = new AppDbContext(options);
        }

        public static DataContext Instance => _instance.Value;


        public void AddPlayers(List<Player> players)
        {
            _dbContext.Players.AddRange(players);
            _dbContext.SaveChanges();
        }

        public void AddWinsToPlayer(int playerId)
        {
            var player = _dbContext.Players.FirstOrDefault(p => p.Id == playerId);
            if (player != null)
            {
                player.Wins++;
                _dbContext.SaveChanges();
            }
        }

        public List<Player> GetPlayers()
        {
            return _dbContext.Players.ToList();
        }
    }
}