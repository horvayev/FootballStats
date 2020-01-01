namespace Application.UseCases.CreateTeam
{
    public class CreateTeamOutput : IUseCaseOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stadium { get; set; }
    }
}