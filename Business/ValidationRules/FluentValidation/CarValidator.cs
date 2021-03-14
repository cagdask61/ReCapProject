using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).Length(2, 50);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.CarName).Must(StartWithMy).WithMessage("Araba ismi My ile başlamalıdır!");
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).Length(5, 500);

        }
        //private bool StartWithMy(string arg)
        //{
        //    return arg.StartsWith("My");
        //}

        
    }
}
