namespace Application.UseCases.CreateTeam
{
    public class CreateTeamInput : IUseCaseInput
    {
        public string Name { get; set; }
        public string Stadium { get; set; }
    }
}