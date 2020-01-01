using System.Collections;
using System.Collections.Generic;
using Domain.Entities;

namespace Infrastructure.InMemoryDataAccess
{
    public class FootballStatsContext
    {
        public List<Team> Teams { get; set; } 

        public FootballStatsContext()
        {
            Teams = new List<Team>();
        }
    }
}