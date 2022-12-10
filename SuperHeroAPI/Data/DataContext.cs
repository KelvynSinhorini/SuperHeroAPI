global using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=desktop-2n6p5us\\mssqlserver01;Initial Catalog=superherodb;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
