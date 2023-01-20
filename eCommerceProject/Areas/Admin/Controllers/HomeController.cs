using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Indexx()
        {
            return View();
        }
    }
}
