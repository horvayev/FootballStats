namespace Application.Validation.Rules
{
    class RequiredRule : IRule<object>
    {
        public bool Check(object obj, string fieldName, ValidationResult validationResult)
        {
            if (obj == null)
            {
                validationResult.AddError(new ValidationError($"'{fieldName}' is required."));
                return false;
            }
            else if (obj is string && string.IsNullOrWhiteSpace((string)obj))
            {
                validationResult.AddError(new ValidationError($"'{fieldName}' can not be empty."));
                return false;
            }

            return true;
        }
    }
}
