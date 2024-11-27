using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty()
                .WithMessage("Ürün adı alanı boş geçilemez.");

            RuleFor(p => p.Category)
                .NotNull()
                .WithMessage("Ürün kategorisi boş geçilemez.");

            RuleFor(p => p.Supplier)
               .NotNull()
               .WithMessage("Ürün tedarikçisi boş geçilemez.");
        }
    }
}
