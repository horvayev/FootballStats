using System.Collections.Generic;
using System.Linq;
using Application.UseCases.GetTeams;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels;

namespace WebApi.UseCases.GetTeams
{
    public class GetTeamsPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set;}

        public void Standard(GetTeamsOutput output)
        {
            var teams = output.Teams.Select(t => new TeamModel () {
                Id = t.Id,
                Name = t.Name,                    
                Stadium = t.Stadium
            }).ToList();

            GetTeamsResponse response = new GetTeamsResponse(teams.Count);
            response.AddRange(teams);

            ViewModel = new ObjectResult(response);
        }
    }
}