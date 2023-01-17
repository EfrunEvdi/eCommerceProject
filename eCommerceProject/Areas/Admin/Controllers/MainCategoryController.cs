﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace eCommerceProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainCategoryController : Controller
    {
        MainCategoryManager mcm = new MainCategoryManager(new EfMainCategoryRepository());
        public IActionResult Index()
        {
            var values = mcm.TGetList();
            return View(values);
        }

        //Ekleme
        [HttpGet]
        public IActionResult AddMainCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMainCategory(MainCategory mainCategory)
        {

            MainCategoryValidator validations = new MainCategoryValidator();
            ValidationResult results = validations.Validate(mainCategory);

            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {

                mcm.TAdd(mainCategory);
                return RedirectToAction("Index");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
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
        //Silme
        public IActionResult DeleteMainCategory(int id)
        {
            var values = mcm.TGetByID(id);
            mcm.TDelete(values);
            return RedirectToAction("Index");
        }

        //Güncelleme
        [HttpGet]
        public IActionResult EditMainCategory(int id)
        {

            var values = mcm.TGetByID(id);
            mcm.TUpdate(values);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditMainCategory(MainCategory mainCategory)
        {
            MainCategoryValidator validations = new MainCategoryValidator();
            ValidationResult results = validations.Validate(mainCategory);

            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {

                mcm.TUpdate(mainCategory);
                return RedirectToAction("Index");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
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
