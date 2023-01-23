using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        Context context = new Context();
        TraderManager tm = new TraderManager(new EfTraderRepository());
        ProductManager mc = new ProductManager(new EfProductRepository());

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult MyAdverts()
        {
            var username = User.Identity.Name;
            ViewBag.ad = username;
            
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            var values = mc.GetProductWithSellTraderID(traderId);
            return View(values);
        }
  


        public IActionResult MyGet()
        {
            var username = User.Identity.Name;
            ViewBag.ad = username;

            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            var values = mc.GetProductWithBuyTraderID(traderId);
            return View(values);
        }
        public IActionResult MySell()
        {
            var username = User.Identity.Name;
            ViewBag.ad = username;

            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            var values = mc.GetProductWithSellTraderID(traderId);
            return View(values);
        }
        public IActionResult MyProductsToBeApproved()
        {
            var username = User.Identity.Name;
            ViewBag.ad = username;

            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            var values = mc.GetProductWithSellTraderID(traderId);
            return View(values);
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            var username = User.Identity.Name;
            ViewBag.ad = username;

            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            var values = tm.TGetByID(traderId);
            tm.TUpdate(values);
            return View(values);
        }

        [HttpPost]
        public IActionResult MyProfile(Trader trader)
        {
            var username = User.Identity.Name;
            ViewBag.ad = username;

            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            trader.TraderID = traderId;
            tm.TUpdate(trader);
            return RedirectToAction("MySell", "Profile");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
        }
    }
}
