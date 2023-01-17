using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GenreCategoryValidator : AbstractValidator<GenreCategory>
    {
        public GenreCategoryValidator()
        {
            RuleFor(x => x.NameGenreCategory).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrlGenreCategory).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.SubCategoryID).NotEmpty().WithMessage("Ara kategori seçmelisiniz.");
        }
    }
}
