using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.CustomerName).NotEmpty().WithMessage("Customer name cannot be empty!");

            RuleFor(customer => customer.CustomerPhone).NotEmpty().WithMessage("Customer phone cannot be empty!");

            RuleFor(customer => customer.CustomerAddress).NotEmpty().WithMessage("Customer address cannot be empty!");

            RuleFor(customer => customer.CustomerMail).NotEmpty().WithMessage("Customer mail cannot be empty!");
        }
    }
}
