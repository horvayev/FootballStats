using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Application.UseCases.CreateTeam;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.CreateTeam
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly CreateTeamPresenter _presenter;
        private readonly ICreateTeamUseCase _useCase;
        private readonly IMapper _mapper;

        public TeamsController(ICreateTeamUseCase useCase, CreateTeamPresenter presenter, IMapper mapper)
        {
            _useCase = useCase;
            _presenter = presenter;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateTeamResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] CreateTeamRequest request)
        {
            CreateTeamInput input = _mapper.Map<CreateTeamInput>(request);
            await _useCase.Execute(input);
            return _presenter.ViewModel;
        }
    }
}