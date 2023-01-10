using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class TraderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
