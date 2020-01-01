using Microsoft.Extensions.DependencyInjection;
using WebApi.Controllers.CreateTeam;
using WebApi.UseCases.GetTeams;

namespace WebApi.DependencyInjection
{
    public static class UserInterfaceExtensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CreateTeamPresenter>();
            services.AddScoped<Application.UseCases.CreateTeam.IOutputPort>(x => x.GetRequiredService<CreateTeamPresenter>());

            services.AddScoped<GetTeamsPresenter>();
            services.AddScoped<Application.UseCases.GetTeams.IOutputPort>(x => x.GetRequiredService<GetTeamsPresenter>());

            return services;
        }
    }
}