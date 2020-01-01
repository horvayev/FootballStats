using Application.UseCases.CreateTeam;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.CreateTeam
{
    public class CreateTeamPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set;}
        
        public void Exception(DomainException exception)
        {
            ViewModel = new BadRequestObjectResult(exception.Message);
        }

        public void NotFound(string message)
        {
            throw new System.NotImplementedException();
        }

        public void Standard(CreateTeamOutput output)
        {
            CreateTeamResponse response = new CreateTeamResponse 
            {
                Id = output.Id,
                Name = output.Name,
                Stadium = output.Stadium
            };

            ViewModel = new ObjectResult(response);
        }
    }
}