namespace Application.UseCases.CreateTeam
{
    public interface IOutputPort : IOutputPortStandard<CreateTeamOutput>, IOutputPortNotFound, IOutputPortException
    {
         
    }
}