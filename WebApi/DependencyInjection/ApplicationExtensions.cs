using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DependencyInjection
{
    public static class ApplicatinExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<Application.UseCases.CreateTeam.ICreateTeamUseCase, Application.UseCases.CreateTeam.CreateTeamUseCase>();
            services.AddScoped<Application.UseCases.GetTeams.IGetTeamsUseCase, Application.UseCases.GetTeams.GetTeamsUseCase>();
            return services;
        }
    }
}