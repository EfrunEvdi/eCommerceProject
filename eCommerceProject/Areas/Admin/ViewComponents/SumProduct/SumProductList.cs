using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace eCommerceProject.Areas.Admin.ViewComponents.SumProduct
{
    [Area("Admin")]

    public class SumProductList : ViewComponent
    {
        ProductManager apm = new ProductManager(new EfProductRepository());
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.top1 = ((long)context.Products.Where(x => x.BuyTraderID != null && x.StatusProduct == false).Sum(y => y.PriceProduct));
            ViewBag.top2 = ((long)context.Products.Where(x => x.StatusProduct == true && x.BuyTraderID == null).Sum(y => y.PriceProduct));
            //ViewBag.value2 = context.Products.Where(x => x.StatusProduct == true).Count();

            ViewBag.Confirm = context.Products.Where(x => x.BuyTraderID == null && x.StatusProduct == false).Count();
            return View();
        }
    }
}
