using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Bowling_Alley.src
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data Source=DESKTOP-OB8A5A7;Initial Catalog=InlUppgift;Integrated Security=SSPI;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connString);
        }
    }
}