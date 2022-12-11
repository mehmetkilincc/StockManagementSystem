using FluentValidation;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.ValidationRules.FluentValidation
{
    public class BrandValidator: AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(brand => brand.CategoryName).NotNull().NotEmpty().WithMessage("Category name cannot be left blank.");

            RuleFor(brand => brand.BrandName).NotNull().NotEmpty().WithMessage("Brand name cannot be left blank.");
        }
    }
}
