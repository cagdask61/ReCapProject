using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).Length(3,50);

            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).Length(1,50);

            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).Length(8,50);

            RuleFor(u => u.LastName).Length(1,50);
            
        }
    }
}
