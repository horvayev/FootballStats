using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            if (environment.EnvironmentName == "Development")
            {
                services.AddSingleton<Infrastructure.InMemoryDataAccess.FootballStatsContext>();
                services.AddScoped<ITeamRepository, Infrastructure.InMemoryDataAccess.Repositories.TeamRepository>();
            }
            else 
            {
                var connectionString = configuration.GetValue<string>("database:connectionString");
                services.AddDbContext<Infrastructure.EFDataAccess.FootballStatsDbContext>(options => {
                    options.UseNpgsql(connectionString);                    
                });
                services.AddScoped<ITeamRepository, Infrastructure.EFDataAccess.Repositories.TeamRepository>();
            }

            return services;
        }
    }
}