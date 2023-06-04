using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Application.CompanyActivities.Commands.CreateCompanyActivity
{
    public class CreateCompanyActivityCommandValidator : AbstractValidator<CreateCompanyActivityCommand>
    {
        public CreateCompanyActivityCommandValidator()
        {
            RuleFor(v => v.ActivityName)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}
