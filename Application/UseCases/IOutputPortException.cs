using Domain;

namespace Application.UseCases
{
    public interface IOutputPortException
    {
         void Exception(DomainException exception);
    }
}