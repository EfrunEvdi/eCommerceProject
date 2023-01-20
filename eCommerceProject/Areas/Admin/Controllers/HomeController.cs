using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eCommerceProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Indexx()
        {
            return View();
        }
       

    }
}
