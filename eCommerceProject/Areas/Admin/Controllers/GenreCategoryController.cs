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
    public class GenreCategoryController : Controller
    {
        GenreCategoryManager agcm = new GenreCategoryManager(new EfGenreCategoryRepository());
        SubCategoryManager ascm = new SubCategoryManager(new EfSubCategoryRepository());

        public IActionResult Index()
        {
            var values = agcm.GetGenreCategoryListWithSub();
            return View(values);
        }

        //Ekleme
        [HttpGet]
        public IActionResult AddGenreCategory()
        {
            List<SelectListItem> category = (from x in ascm.TGetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.NameSubCategory,
                                                 Value = x.SubCategoryID.ToString(),
                                             }).ToList();
            ViewBag.cv = category;
            return View();
        }

        [HttpPost]
        public IActionResult AddGenreCategory(GenreCategory genreCategory)
        {
            GenreCategoryValidator validations = new GenreCategoryValidator();
            ValidationResult results = validations.Validate(genreCategory);

            if (results.IsValid)
            {
                agcm.TAdd(genreCategory);
                return RedirectToAction("GenreCategory", "Admin");
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
        //Silme
        public IActionResult DeleteGenreCategory(int id)
        {
            var values = agcm.TGetByID(id);
            agcm.TDelete(values);
            return RedirectToAction("GenreCategory", "Admin");
        }

        //Güncelleme

        [HttpGet]
        public IActionResult EditGenreCategory(int id)
        {
            var values = agcm.TGetByID(id);
            List<SelectListItem> categoryvalues = (from x in ascm.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.NameSubCategory,
                                                       Value = x.SubCategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGenreCategory(GenreCategory genreCategory)
        {
            GenreCategoryValidator validations = new GenreCategoryValidator();
            ValidationResult results = validations.Validate(genreCategory);

            if (results.IsValid)
            {
                agcm.TUpdate(genreCategory);
                return RedirectToAction("GenreCategory", "Admin");
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
