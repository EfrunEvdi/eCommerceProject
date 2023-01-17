using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eCommerceProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            ProductManager pm = new ProductManager(new EfProductRepository());
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.ProductID = 2; //burada ProductID=2 dediğimiz için hangi sayfada yorum yaparsak yapalım 2 ID'li ürüne yorum eklenecek
            cm.TAdd(comment);
            return PartialView();
        }

    }
}
