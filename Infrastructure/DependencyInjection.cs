using Application.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

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
                services.AddScoped<ITeamRepository, EFDataAccess.Repositories.TeamRepository>();
            }

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}