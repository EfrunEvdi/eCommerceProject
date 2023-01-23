using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    [AllowAnonymous]

    public class GenreCategoryController : Controller
    {
        GenreCategoryManager gcm = new GenreCategoryManager(new EfGenreCategoryRepository());
        public IActionResult Index(int id)
        {
            //ViewBag.i = id;
            var values = gcm.TGetList();
            return View(values);
        }
    }
}
