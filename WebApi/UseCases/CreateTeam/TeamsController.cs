using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Application.UseCases.CreateTeam;
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

        public TeamsController(ICreateTeamUseCase useCase, CreateTeamPresenter presenter)
        {
            _useCase = useCase;
            _presenter = presenter;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateTeamResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] CreateTeamRequest request)
        {
            var input = new CreateTeamInput
            {
                Name = request.Name,
                Stadium = request.Stadium
            };
            await _useCase.Execute(input);
            return _presenter.ViewModel;
        }
    }
}