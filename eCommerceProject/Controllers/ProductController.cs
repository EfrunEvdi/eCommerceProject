﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

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
        public IActionResult ProductAdd()
        {
            //ViewBag.v1 = "Deneyim Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            //ViewBag.v2 = "Deneyimler";
            //ViewBag.v3 = "Deneyim Ekleme";
            GenreCategoryManager gc = new GenreCategoryManager (new EfGenreCategoryRepository());
            List<SelectListItem> categoryvalues= (from x in gc.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.NameGenreCategory,
                                                      Value=x.GenreCategoryID.ToString()    
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


    }
}
