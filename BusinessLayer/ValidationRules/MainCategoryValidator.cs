using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MainCategoryValidator : AbstractValidator<MainCategory>
    {
        public MainCategoryValidator()
        {
            //Rulefor metodu ile form içerisinde değer girişinde etki ve kontrol tanımlamaları yaparız.
            RuleFor(x => x.NameMainCategory).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrlMainCategory).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
        }
    }
}
