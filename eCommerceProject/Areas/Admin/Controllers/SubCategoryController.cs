using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace eCommerceProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        SubCategoryManager ascm = new SubCategoryManager(new EfSubCategoryRepository());
        MainCategoryManager amcm = new MainCategoryManager(new EfMainCategoryRepository());

        public IActionResult Index()
        {
            var values = ascm.GetSubCategoryListWithMain();
            return View(values);
        }

        //Ekleme
        [HttpGet]
        public IActionResult AddSubCategory()
        {
            List<SelectListItem> category = (from x in amcm.TGetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.NameMainCategory,
                                                 Value = x.MainCategoryID.ToString()
                                             }).ToList();

            //var values = ascm.TGetList();
            ViewBag.cv = category;
            return View();
        }

        [HttpPost]
        public IActionResult AddSubCategory(SubCategory subCategory)
        {
            SubCategoryValidator validations = new SubCategoryValidator();
            ValidationResult results = validations.Validate(subCategory);

            if (results.IsValid)
            {
                ascm.TAdd(subCategory);
                return RedirectToAction("SubCategory", "Admin");
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
        public IActionResult DeleteSubCategory(int id)
        {
            var values = ascm.TGetByID(id);
            ascm.TDelete(values);
            return RedirectToAction("SubCategory", "Admin");
        }

        //Güncelleme

        [HttpGet]
        public IActionResult EditSubCategory(int id)
        {
            var values = ascm.TGetByID(id);
            List<SelectListItem> categoryvalues = (from x in amcm.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.NameMainCategory,
                                                       Value = x.MainCategoryID.ToString(),
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(values);
        }

        [HttpPost]
        public IActionResult EditSubCategory(SubCategory subCategory)
        {
            SubCategoryValidator validations = new SubCategoryValidator();
            ValidationResult results = validations.Validate(subCategory);

            if (results.IsValid)
            {
                ascm.TUpdate(subCategory);
                return RedirectToAction("SubCategory", "Admin");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
