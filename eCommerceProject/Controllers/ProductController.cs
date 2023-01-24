using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using eCommerceProject.Models;
using EntityLayer.Concrete;
using FluentValidation.Internal;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;

namespace eCommerceProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        Context context = new Context();
        ProductManager pm = new ProductManager(new EfProductRepository());

        public ProductController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = pm.TGetList();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult ProductDetails(int id)
        {
            ViewBag.i = id;
            var values = pm.TGetList(id);
            return View(values);
        }
        [Authorize]
        public IActionResult DetailsProduct(int id)
        {
            ViewBag.i = id;
            var values = pm.TGetList(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var values = pm.TGetByID(id);
            pm.TUpdate(values);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            ProductValidator validations = new ProductValidator();
            ValidationResult results = validations.Validate(product);


            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {
                var username = User.Identity.Name;
                ViewBag.ad = username;

                var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
                var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();


                product.DateProduct = DateTime.Parse(DateTime.Now.ToShortDateString());
                pm.TUpdate(product);
                return RedirectToAction("MyProductsToBeApproved", "Profile");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Burada hata ismi ve mesajını alıp add sayfasına gönderdik
                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult AddProduct(int id)
        {
            //ViewBag.v1 = "Deneyim Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            //ViewBag.v2 = "Deneyimler";
            //ViewBag.v3 = "Deneyim Ekleme";
            GenreCategoryManager gcm = new GenreCategoryManager(new EfGenreCategoryRepository());


            List<SelectListItem> categoryvalues = (from x in gcm.TGetList(id)
                                                   select new SelectListItem
                                                   {
                                                       Text = x.NameGenreCategory,
                                                       Value = x.GenreCategoryID.ToString(),


                                                   }).ToList();

            ViewBag.cv = categoryvalues;

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product, ProductAddViewModel p)
        {
            //ProductValidator validations = new ProductValidator();
            //ValidationResult results = validations.Validate(product);

            //if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            //{
            var username = User.Identity.Name;
            ViewBag.ad = username;

            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();

            product.SellTraderID = traderId;   //burada authentice olan traderın traderId'si Products tablosunda SellTraderId olarak kayıt olacak
            product.DateProduct = DateTime.Parse(DateTime.Now.ToShortDateString());

            //ViewBag.i = p.productimageurl1;
            var extension = Path.GetExtension(p.productimageurl1.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimage/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            p.productimageurl1.CopyTo(stream);
            product.ImageUrl1Product = "/productimage/" + newImageName;


            var extension2 = Path.GetExtension(p.productimageurl2.FileName);
            var newImageName2 = Guid.NewGuid() + extension2;
            var location2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimage/", newImageName2);
            var stream2 = new FileStream(location2, FileMode.Create);
            p.productimageurl2.CopyTo(stream2);
            product.ImageUrl2Product = "/productimage/" + newImageName2;

            var extension3 = Path.GetExtension(p.productimageurl3.FileName);
            var newImageName3 = Guid.NewGuid() + extension3;
            var location3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimage/", newImageName3);
            var stream3 = new FileStream(location3, FileMode.Create);
            p.productimageurl3.CopyTo(stream3);
            product.ImageUrl3Product = "/productimage/" + newImageName3;

            var extension4 = Path.GetExtension(p.productimageurl4.FileName);
            var newImageName4 = Guid.NewGuid() + extension4;
            var location4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimage/", newImageName4);
            var stream4 = new FileStream(location4, FileMode.Create);
            p.productimageurl4.CopyTo(stream4);
            product.ImageUrl4Product = "/productimage/" + newImageName4;

            var extension5 = Path.GetExtension(p.productimageurl5.FileName);
            var newImageName5 = Guid.NewGuid() + extension5;
            var location5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimage/", newImageName5);
            var stream5 = new FileStream(location5, FileMode.Create);
            p.productimageurl5.CopyTo(stream5);
            product.ImageUrl5Product = "/productimage/" + newImageName5;

            var extension6 = Path.GetExtension(p.productimageurl6.FileName);
            var newImageName6 = Guid.NewGuid() + extension6;
            var location6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimage/", newImageName6);
            var stream6 = new FileStream(location6, FileMode.Create);
            p.productimageurl6.CopyTo(stream6);
            product.ImageUrl6Product = "/productimage/" + newImageName6;



            pm.TAdd(product);
            return RedirectToAction("MyProductsToBeApproved", "Profile");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık

            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Burada hata ismi ve mesajını alıp add sayfasına gönderdik
            //    }
            //}
            //return View();
        }
        public IActionResult BuyProduct(int id)
        {
            ViewBag.i = id;
            var values = pm.TGetList(id);
            return View(values);
        }
        public IActionResult CheckOut(int id, Product p, Trader t)
        {
            p.ProductID = id;
            ViewBag.i = id;
            ViewBag.SI = context.Products.Where(x => x.ProductID == id).Select(y => y.SellTraderID).FirstOrDefault();

            t.TraderID = ViewBag.SI;
            int a = ViewBag.SI;

            ViewBag.ad = context.Traders.Where(x => x.TraderID == a).Select(y => y.TraderUserName).FirstOrDefault();
            ViewBag.IBAN = context.Traders.Where(x => x.TraderID == a).Select(y => y.IBANTrader).FirstOrDefault();



            var values = pm.TGetList(id);
            return View(values);

        }
        public IActionResult LastBuy(int id)
        {
            var username = User.Identity.Name;
            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            var tumsatir = context.Products.SingleOrDefault(x => x.ProductID == id);

            if (tumsatir != null)
            {
                tumsatir.BuyTraderID = traderId;
                tumsatir.StatusProduct = false;
                pm.TUpdate(tumsatir);
            }

            return RedirectToAction("MyGet", "Profile");
        }
    }
}
