using System.Collections.Generic;

namespace Application.Validation
{
    public class ValidationResult
    {
        public List<ValidationError> Errors { get; }
        public bool IsValid { get => Errors.Count == 0; }

        public ValidationResult()
        {
            Errors = new List<ValidationError>();
        }

        public void AddError(ValidationError error)
        {
            Errors.Add(error);
        }       
    }

    public class ValidationError
    {
        public string ErrorMessage { get; }

        public ValidationError(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}