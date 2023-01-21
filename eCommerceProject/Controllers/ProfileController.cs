using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        public IActionResult MyProductsToBeApproved()
        {
            var values = mc.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            var values = tm.TGetByID(3);
            tm.TUpdate(values);
            return View(values);
        }

        [HttpPost]
        public IActionResult MyProfile(Trader trader)
        {
            trader.TraderID = 3;
            tm.TUpdate(trader);
            return RedirectToAction("MySell", "Profile");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
        }
    }
}
