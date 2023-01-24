using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace eCommerceProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        ProductManager apm = new ProductManager(new EfProductRepository());
        GenreCategoryManager agcm = new GenreCategoryManager(new EfGenreCategoryRepository());
        Context context = new Context();

        public IActionResult Index()
        {
            var values = apm.GetProductListWithSub();
            return View(values);
        }

        //Onaylama
        [HttpGet]
        public IActionResult ConfirmProduct(int id)
        {
            var values = apm.TGetByID(id);
            List<SelectListItem> categoryvalues = (from x in agcm.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.NameGenreCategory,
                                                       Value = x.GenreCategoryID.ToString(),
                                                   }).ToList();



            ViewBag.cv = categoryvalues;
            return View(values);
        }

        [HttpPost]
        public IActionResult ConfirmProduct(Product product)
        {
            apm.TUpdate(product);
            return RedirectToAction("Product", "Admin");
        }



        //public IActionResult ConfirmProduct(int id, Product product)
        //{
        //    if (product.StatusProduct == false && product.BuyTrader == null)
        //    {
        //        var values = apm.TGetByID(id);
        //        var anan = context.Products.Where(x => x.StatusProduct == false).FirstOrDefault();
        //        product.StatusProduct = true;
        //        apm.TUpdate(values);
        //    }

        //    return RedirectToAction("Product", "Admin");
        //}

        //Silme
        public IActionResult DeleteProduct(int id)
        {
            var values = apm.TGetByID(id);
            apm.TDelete(values);
            return RedirectToAction("Product", "Admin");
        }
    }
}
