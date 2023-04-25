using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace calisanlar.DataBase
{
    public class ApplicationConnectionDb : DbContext
    {
        public DbSet<Kisi> Kisi { get; set; }
 
        ServerVersion ServerVersion { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=localhost;port=3306;user=root;password=;database=calisanlar", new MySqlServerVersion(new Version(7,4,29)), null)
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
