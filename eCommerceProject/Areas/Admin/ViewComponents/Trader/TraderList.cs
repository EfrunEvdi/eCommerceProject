using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;

namespace eCommerceProject.Areas.Admin.ViewComponents.Trader
{
    [Area("Admin")]

    public class TraderList : ViewComponent
    {
        TraderManager atm = new TraderManager(new EfTraderRepository());
        ProductManager apm = new ProductManager(new EfProductRepository());
        Context context = new Context();
        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {

            //var username = User.Identity.Name;
            //var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //var writerid = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();

            // Yukarıdaki İdentity yapılınca aktif edip düzenlenecek.

            ViewBag.value1 = context.Traders.Count();

            ViewBag.value2 = context.Products.Where(x => x.StatusProduct == true).Count();

            ViewBag.value3 = context.Products.Where(x => x.StatusProduct == false).Count();

            ViewBag.Confirm = context.Products.Where(x => x.BuyTraderID == null && x.StatusProduct == false).Count();

            return View();
        }
    }
}
