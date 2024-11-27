using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Kategori alanı boş geçilemez.")
                .MinimumLength(5).WithMessage("Kategori adı minimum 5 karakter olmadılıdır.")
                .MaximumLength(25).WithMessage("Kategori adı maximum 25 karakter olmadılıdır.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ\\s]+$").WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
        }
    }
}
