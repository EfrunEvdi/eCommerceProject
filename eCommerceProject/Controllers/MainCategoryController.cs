using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class MainCategoryController : Controller
    {
        MainCategoryManager mcm = new MainCategoryManager(new EfMainCategoryRepository());
        public IActionResult Index()
        {
            
            var values=mcm.TGetList();  
            return View(values);
        }
    }
}
