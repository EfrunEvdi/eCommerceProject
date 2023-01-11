using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
