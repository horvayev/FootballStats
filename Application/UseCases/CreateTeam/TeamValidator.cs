using Application.Validation.Rules;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Validation
{
    class TeamValidator : IValidator<Team>
    {
        public ValidationResult Validate(Team team)
        {
            ValidationResult rv = new ValidationResult();
            RequiredRule rule = new RequiredRule();

            rule.Check(team.Name, nameof(team.Name), rv);
            rule.Check(team.Stadium, nameof(team.Stadium), rv);

            return rv;
        }
    }
}
