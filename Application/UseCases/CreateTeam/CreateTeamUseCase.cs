using System.Threading.Tasks;
using Application.Exceptions;
using Application.Repositories;
using Domain.Entities;

namespace Application.UseCases.CreateTeam
{
    public class CreateTeamUseCase : ICreateTeamUseCase
    {
        private IOutputPort _outputPort;
        private ITeamRepository _teamRepository;

        public CreateTeamUseCase(ITeamRepository teamRepository, IOutputPort outputPort)
        {
            _teamRepository = teamRepository;
            _outputPort = outputPort;
        }

        public async Task Execute(CreateTeamInput input)
        {
            // business login in here
            Team storedTeam = await _teamRepository.GetByName(input.Name);

            if (storedTeam != null) 
            {
                _outputPort.Exception(new AlreadyExistsException("Team", "Name", input.Name));                
            }

            Team team = await _teamRepository.Add(new Team {
                Name = input.Name,
                Stadium = input.Stadium
            });

            _outputPort.Standard(new CreateTeamOutput {
                Id = team.Id,
                Name = team.Name,
                Stadium = team.Stadium
            });
        }
    }
}