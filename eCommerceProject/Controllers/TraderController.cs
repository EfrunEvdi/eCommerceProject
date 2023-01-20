﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    //[Authorize]
    //[AllowAnonymous]
    public class TraderController : Controller
    {

        ProductManager mc = new ProductManager(new EfProductRepository());
        public IActionResult ilanlarim()
        {
            var values = mc.TGetList();
            return View(values);
        }
        public IActionResult aldiklarim()
        {
            var values = mc.TGetList();
            return View(values);
        }
        public IActionResult sattiklarim()
        {
            var values = mc.TGetList();
            return View(values);
        }
    }
}
