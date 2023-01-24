using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
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
        public IActionResult ProductAdd(int id)
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
        public IActionResult ProductAdd(Product product)
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
                product.SellTraderID = 3;
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

    }
}
