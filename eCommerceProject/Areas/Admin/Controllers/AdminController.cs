using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        //        eğer area kullanıyorsak sayfanın Controller'ında attribute routing yapılmalı ve hangi area kullanılıyorsa belirtilmelidir, ayrıca area eklerken area'nın ScaffoldindReadMe sayfasındaki vermiş routing kodunu da start up içindeki routing alanına eklememiz gerekir. Register klasöründe Post Add view'den index geldi
        public IActionResult Index()
        {
            return View();
        }
    }
}
