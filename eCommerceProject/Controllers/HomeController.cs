using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using eCommerceProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceProject.Controllers
{
    public class HomeController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var values = pm.TGetList();
            return View(values);
        }

        public IActionResult ProductDetails(int id)
        {
            ViewBag.i = id;
            var values = pm.TGetList(id);
            return View(values);
        }
    }

    
}
