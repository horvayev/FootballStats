using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Validation
{
    interface IValidator<in TModel> where TModel : class
    {
        ValidationResult Validate(TModel model);
    }
}
