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
            ViewBag.top1 = ((long)context.Products.Where(x => x.StatusProduct == false).Sum(y => y.PriceProduct));
            ViewBag.top2 = ((long)context.Products.Where(x => x.StatusProduct == true).Sum(y => y.PriceProduct));
            return View();
        }
    }
}
