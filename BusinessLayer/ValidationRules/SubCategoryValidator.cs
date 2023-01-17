using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SubCategoryValidator : AbstractValidator<SubCategory>
    {
        public SubCategoryValidator()
        {
            RuleFor(x => x.NameSubCategory).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrlSubCategory).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.MainCategoryID).NotEmpty().WithMessage("Ana kategori seçmelisiniz.");
        }
    }
}
