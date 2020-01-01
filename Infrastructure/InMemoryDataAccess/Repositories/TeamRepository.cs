using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.InMemoryDataAccess.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly FootballStatsContext _context;

        public TeamRepository(FootballStatsContext context)
        {
            _context = context;
        }
        
        public Task<Team> Add(Team entity)
        {
            entity.Id = new Random().Next();
            _context.Teams.Add(entity);     
            return Task.FromResult(entity);   
        }

        public Task Delete(Team entity)
        {
            var storedEntity =_context.Teams.FirstOrDefault(x => x.Id == entity.Id);
            if (storedEntity != null) 
            {
                _context.Teams.Remove(storedEntity);
            }
            return Task.FromResult(0);
        }

        public Task<IEnumerable<Team>> GetAll()
        {
            var rv = new List<Team>(_context.Teams.ToArray());
            return Task.FromResult<IEnumerable<Team>>(rv);
        }

        public Task<Team> GetById(int id)
        {
            return Task.FromResult(_context.Teams.FirstOrDefault(x => x.Id == id));
        }

        public Task<Team> GetByName(string name)
        {
            return Task.FromResult(_context.Teams.FirstOrDefault(x => x.Name == name));
        }

        public Task Update(Team entity)
        {
            int idx = _context.Teams.ToList().FindIndex(0, 1, x => x.Id == entity.Id);
            if (idx >= 0) 
            {
                _context.Teams[idx] = entity;
            }
            return Task.FromResult(0);
        }
    }
}