using Microsoft.EntityFrameworkCore;

namespace Bowling_Alley.src
{
    public class AppDbContext : DbContext
    {
        private static readonly string _connectionString =
            "Data Source=DESKTOP-OB8A5A7;Initial Catalog=InlUppgift;Integrated Security=SSPI;TrustServerCertificate=True;";

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
}
