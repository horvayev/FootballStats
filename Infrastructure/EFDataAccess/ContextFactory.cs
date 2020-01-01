using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.EFDataAccess
{
    public class ContextFactory : IDesignTimeDbContextFactory<FootballStatsDbContext>
    {
        public FootballStatsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.production.json")
                .Build();
 
            DbContextOptionsBuilder<FootballStatsDbContext> builder = new DbContextOptionsBuilder<FootballStatsDbContext>();
            string connectionString = configuration.GetValue<string>("database:connectionString");

            builder.UseNpgsql(connectionString);                        
            return new FootballStatsDbContext (builder.Options);
        }
    }
}