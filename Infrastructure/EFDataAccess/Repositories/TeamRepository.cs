using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.EFDataAccess.Repositories
{
    public sealed class TeamRepository : ITeamRepository
    {
        private FootballStatsDbContext _context;

        public TeamRepository(FootballStatsDbContext context)
        {
            _context = context;
        }

        public Task<Team> Add(Team entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Team entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Team>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Team> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Team> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Team entity)
        {
            throw new System.NotImplementedException();
        }
    }
}