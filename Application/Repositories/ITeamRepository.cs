using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        Task<Team> GetByName(string name);
    }
}