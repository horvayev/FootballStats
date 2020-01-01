using System.Threading.Tasks;
using Application.UseCases.GetTeams;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.UseCases.GetTeams
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly GetTeamsPresenter _presenter;
        private readonly IGetTeamsUseCase _useCase;

        public TeamsController(IGetTeamsUseCase useCase, GetTeamsPresenter presenter)
        {
            _useCase = useCase;
            _presenter = presenter;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetTeamsResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {            
            await _useCase.Execute(new GetTeamsInput());
            return _presenter.ViewModel;
        }
    }
}