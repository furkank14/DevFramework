using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;

namespace DevFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.UserName).Length(3, 20);
            RuleFor(p => p.FirstName).Length(3, 20);
            RuleFor(p => p.LastName).Length(3, 20);
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.LastName).Length(6,50);

        }
    }
}
