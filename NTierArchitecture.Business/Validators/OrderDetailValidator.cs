using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(o => o.ProductID).NotEmpty()
                .WithMessage("Ürün ID bilgisi boş olamaz.");

            RuleFor(o => o.OrderID).NotEmpty()
              .WithMessage("Sipariş ID bilgisi boş olamaz.");

            RuleFor(o => o.UnitPrice).NotEmpty()
               .WithMessage("Birim fiyat bilgisi boş olamaz.")
               .GreaterThan(0)
               .WithMessage("Ürün fiyatı 0'dan büyük olmalıdır.");

            RuleFor(o => o.Quantity).NotEmpty()
              .WithMessage("Sipariş adedi bilgisi boş olamaz.")
              .GreaterThanOrEqualTo(1)
              .WithMessage("Sipariş adedi en az 1 olmalıdır.");

        }
    }
}
