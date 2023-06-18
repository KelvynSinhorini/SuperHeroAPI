global using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "Server=tcp:skstudying.database.windows.net,1433;Initial Catalog=estudos;Persist Security Info=False;User ID=developer;Password=dev@0033;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";//_configuration["ConnectionStrings:databaseConnection"];
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
