using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.ValidationRules.FluentValidation
{
    public class CartValidator : AbstractValidator<Cart>
    {
        public CartValidator()
        {
            RuleFor(cart => cart.CustomerId).NotEmpty().WithMessage("Customer Id cannot be empty!");

            RuleFor(cart => cart.CustomerName).NotEmpty().WithMessage("Customer name cannot be empty!");

            RuleFor(cart => cart.CustomerId).NotEmpty().WithMessage("Customer phone cannot be empty!");

            RuleFor(cart => cart.ProductId).NotEmpty().WithMessage("Product Id cannot be empty!");

            RuleFor(cart => cart.ProductName).NotEmpty().WithMessage("Customer Id cannot be empty!");

            RuleFor(cart => cart.Amount).NotEmpty().WithMessage("Amount cannot be empty!").GreaterThan(0).WithMessage("Amount must be greater than zero.");
        }
    }
}
