using System.Collections.Generic;
using Domain.Entities;
using WebApi.ViewModels;

namespace WebApi.UseCases.GetTeams
{
    public class GetTeamsResponse : List<TeamModel>
    {
        //     public IList<TeamModel> Teams { get; }

        //     public GetTeamsResponse(IList<TeamModel> teams)
        //     {
        //         Teams = Teams;
        //     }
        // }
        public GetTeamsResponse(int capacity) : base(capacity)
        {
        }
    }
}