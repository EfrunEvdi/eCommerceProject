using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace eCommerceProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        [AllowAnonymous]

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment comment, int pID)
        {
            Context context = new Context();
            ProductManager pm = new ProductManager(new EfProductRepository());
            var username = User.Identity.Name;
            comment.CommentUserName = username;
            ViewBag.isim = username;

            var traderId = context.Traders.Where(x => x.TraderUserName == username).Select(y => y.TraderID).FirstOrDefault();
            ViewBag.id = traderId;
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.ProductID = pID; //burada ProductID=2 dediğimiz için hangi sayfada yorum yaparsak yapalım 2 ID'li ürüne yorum eklenecek
            cm.TAdd(comment);

            return RedirectToAction("DetailsProduct", "Product", new { id = pID });
        }

    }
}
