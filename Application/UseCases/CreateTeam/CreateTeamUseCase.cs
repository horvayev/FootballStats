using System.Threading.Tasks;
using Application.Exceptions;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.CreateTeam
{
    public class CreateTeamUseCase : ICreateTeamUseCase
    {
        private IOutputPort _outputPort;
        private ITeamRepository _teamRepository;
        private IMapper _mapper;

        public CreateTeamUseCase(ITeamRepository teamRepository, IOutputPort outputPort, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task Execute(CreateTeamInput input)
        {
            // business login in here
            Team storedTeam = await _teamRepository.GetByName(input.Name);

            if (storedTeam != null) 
            {
                _outputPort.Exception(new AlreadyExistsException("Team", "Name", input.Name));
                return;
            }

            Team team = _mapper.Map<Team>(input);
            await _teamRepository.Add(team);

            CreateTeamOutput output = _mapper.Map<CreateTeamOutput>(team);
            _outputPort.Standard(output);
        }
    }
}