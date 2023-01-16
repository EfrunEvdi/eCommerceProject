﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace eCommerceProject.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var values = pm.TGetList();
            return View(values);
        }

       

        [HttpGet]
        public IActionResult ProductAdd(int id)
        {
            //ViewBag.v1 = "Deneyim Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            //ViewBag.v2 = "Deneyimler";
            //ViewBag.v3 = "Deneyim Ekleme";
            GenreCategoryManager gc = new GenreCategoryManager (new EfGenreCategoryRepository());
            List<SelectListItem> categoryvalues= (from x in gc.TGetList(id)
                                                  select new SelectListItem
                                                  {
                                                      Text=x.NameGenreCategory,
                                                      Value=x.GenreCategoryID.ToString(),

                                                  }).ToList();
            
            ViewBag.cv = categoryvalues;
            
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            pm.TAdd(product);
            return RedirectToAction("Index");
        }

        public IActionResult ProductDetails()
        {
            var values = pm.TGetList();
            return View(values);
        }
        public IActionResult Test(int id)
        {

            SubCategoryManager scm = new SubCategoryManager(new EfSubCategoryRepository());
            GenreCategoryManager gcm = new GenreCategoryManager(new EfGenreCategoryRepository());
            var subCategory = scm.TGetByID(id);
            //var genreCategory = gcm.TGetByID(id);
            if ( subCategory.SubCategoryID == id )
            {

                var values = pm.GetProductByGenre(id);
                return View(values);
            }
            else { return View(); }
            

        }



    }
}
