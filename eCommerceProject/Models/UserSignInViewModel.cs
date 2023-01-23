using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eCommerceProject.Models
{
	public class UserSignInViewModel
	{
        
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        public string username { get; set; }

        
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string password { get; set; }

        
    }
}
