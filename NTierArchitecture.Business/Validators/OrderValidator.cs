using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.Employee)
                .NotNull()
                .WithMessage("Siparişin çalışan bilgisi boş olamaz.");

            RuleFor(o => o.Customer)
              .NotNull()
              .WithMessage("Siparişin müşteri bilgisi boş olamaz.");

            RuleFor(o => o.OrderDate)
              .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
              .WithMessage("Sipariş tarihi bugünün tarihinden önceki bir tarih olamaz.");
        }
    }
}
