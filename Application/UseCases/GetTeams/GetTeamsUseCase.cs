using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;

namespace Application.UseCases.GetTeams
{
    public class GetTeamsUseCase : IGetTeamsUseCase
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IOutputPort _outputPort;

        public GetTeamsUseCase(ITeamRepository teamRepository, IOutputPort outputPort)
        {
            _teamRepository = teamRepository;
            _outputPort = outputPort;
        }

        public async Task Execute(GetTeamsInput input)
        {
            var teams = await _teamRepository.GetAll();
            _outputPort.Standard(new GetTeamsOutput(teams.ToList()));            
        }
    }
}