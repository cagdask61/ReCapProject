using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).Must(StartWithCarbrand).WithMessage("Arabanın modelini tanımlarken Carbrand ile başlamalıdır!");
        }

        private bool StartWithCarbrand(string arg)
        {
            return arg.StartsWith("Carbrand");
        }
    }
}
