using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class MainCategoryController : Controller
    {
        MainCategoryManager mc = new MainCategoryManager(new EfMainCategoryRepository());
        public IActionResult Index()
        {
            var values = mc.TGetList();
            return View(values);
        }
    }
}
