using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.NameProduct).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.DescriptionProduct).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.BrandProduct).NotEmpty().WithMessage("Marka alanı boş geçilemez.");
            RuleFor(x => x.SizeProduct).NotEmpty().WithMessage("Beden alanı boş geçilemez.");
            RuleFor(x => x.PriceProduct).NotEmpty().WithMessage("Fiyat alanı boş geçilemez.");
            //RuleFor(x => x.DateProduct).NotEmpty().WithMessage("Saat alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl1Product).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl2Product).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl3Product).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl4Product).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl5Product).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl6Product).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
        }
    }
}
