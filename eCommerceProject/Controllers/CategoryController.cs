﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    [AllowAnonymous]

    public class CategoryController : Controller
    {
        public IActionResult SubCategory(int id)
        {
            ProductManager pm = new ProductManager(new EfProductRepository());
            SubCategoryManager scm = new SubCategoryManager(new EfSubCategoryRepository());
            GenreCategoryManager gcm = new GenreCategoryManager(new EfGenreCategoryRepository());
            var subCategory = scm.TGetByID(id);
            //var genreCategory = gcm.TGetByID(id);
            if (subCategory.SubCategoryID == id)
            {

                var values = pm.GetProductByGenre(id);
                return View(values);
            }
            else { return View(); }
        }
    }
}
