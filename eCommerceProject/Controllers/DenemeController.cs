using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
