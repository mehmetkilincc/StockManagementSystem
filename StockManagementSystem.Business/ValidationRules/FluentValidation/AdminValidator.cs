using FluentValidation;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Business.Abstract;

namespace StockManagementSystem.Business.ValidationRules.FluentValidation
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        
        public AdminValidator()
        {
            RuleFor(admin => admin.UserName).NotEmpty().WithMessage("Username cannot be empty!").Length(8, 16).WithMessage("Username must be between 8 and 16 characters");

            RuleFor(admin => admin.Password).NotEmpty().WithMessage("Password cannot be empty!").Length(8, 16).WithMessage("Username must be between 8 and 16 characters");
        }
    }
}
