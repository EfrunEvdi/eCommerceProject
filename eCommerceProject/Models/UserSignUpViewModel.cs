using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace eCommerceProject.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lütfen ad ve soyad giriniz.")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }

        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]

        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil!")]
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        public string ConfirmPassword { get; set; }

        public IFormFile imageurltrader { get; set; }

        public bool IsAcceptTheContract { get; set; }

    }
}
