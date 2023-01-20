using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class ProfileController : Controller
    {
        TraderManager tm = new TraderManager(new EfTraderRepository());
        ProductManager mc = new ProductManager(new EfProductRepository());

        public IActionResult MyAdverts()
        {
            var values = mc.TGetList();
            return View(values);
        }
        public IActionResult MyGet()
        {
            var values = mc.TGetList();
            return View(values);
        }
        public IActionResult MySell()
        {
            var values = mc.TGetList();
            return View(values);
        }

        public IActionResult MyProfile()
        {
            var values = tm.TGetList();
            return View(values);
        }
    }
}
