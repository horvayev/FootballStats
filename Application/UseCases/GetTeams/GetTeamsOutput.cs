using System.Collections.Generic;
using Domain.Entities;

namespace Application.UseCases.GetTeams
{
    public class GetTeamsOutput : IUseCaseOutput
    {
        public IReadOnlyList<Team> Teams { get; }
        
        public GetTeamsOutput(IReadOnlyList<Team> teams)
        {
            Teams = teams;
        }
    }
}