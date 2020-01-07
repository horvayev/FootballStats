using Application.UseCases.CreateTeam;
using Application.Validation;
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
            ViewModel = new BadRequestObjectResult(message);
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

        public void ValidationError(ValidationResult validation)
        {
            ViewModel = new BadRequestObjectResult(validation.Errors[0].ErrorMessage);
        }
    }
}