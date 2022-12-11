using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.ProductName).NotEmpty().WithMessage("Product name cannot be empty!");

            RuleFor(product => product.CategoryName).NotNull().NotEmpty().WithMessage("Category cannot be empty!");

            RuleFor(product => product.BrandName).NotNull().NotEmpty().WithMessage("Brand cannot be empty!");

            RuleFor(product => product.Quantity).NotNull().NotEmpty().WithMessage("Quantity cannot be empty!").GreaterThan(0).WithMessage("Quantity must be greater than zero.");

            RuleFor(product => product.PurchasePrice).NotNull().NotEmpty().WithMessage("Purchase price cannot be empty!").GreaterThan(0).WithMessage("Purchase price must be greater than zero.");

            RuleFor(product => product.SalePrice).NotNull().NotEmpty().WithMessage("Sale price cannot be empty!").GreaterThan(0).WithMessage("Sale price must be greater than zero.");
        }
    }
}
