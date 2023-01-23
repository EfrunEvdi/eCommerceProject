using System.ComponentModel.DataAnnotations;

namespace eCommerceProject.Areas.Admin.Models
{
    public class AdminLoginViewModel
    {
        
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}