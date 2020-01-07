namespace Application.Validation.Rules
{
    interface IRule<T>
    {
        bool Check(T obj, string fieldName, ValidationResult validationResult);
    }
}
