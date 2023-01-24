using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using eCommerceProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
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
        CommentManager cm = new CommentManager(new EfCommentRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = pm.TGetList();
            return View(values);
        }

        [Authorize]
        public IActionResult HomePage()
        {
            var values = pm.TGetList();
            return View(values);
        }


    }
}
