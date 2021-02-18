using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).NotEmpty();
            RuleFor(c => c.ColorName).Must(StartWithCarcolor).WithMessage("Arabının rengini tanımlarken Carcolor ile başlamalıdır!");
        }
        private bool StartWithCarcolor(string arg)
        {
            return arg.StartsWith("Carcolor");
        }
    }
}
