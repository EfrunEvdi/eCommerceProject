using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eCommerceProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AdminController : Controller
    {

        //        eğer area kullanıyorsak sayfanın Controller'ında attribute routing yapılmalı ve hangi area kullanılıyorsa belirtilmelidir, ayrıca area eklerken area'nın ScaffoldindReadMe sayfasındaki vermiş routing kodunu da start up içindeki routing alanına eklememiz gerekir. Register klasöründe Post Add view'den index geldi


        public IActionResult Index()
        {
            return View();
        }



    }

}

