using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class ProductController : Controller
    {
        ProductManager mc = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var values = mc.TGetList();
            return View(values);
        }
    }
}
