using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.ViewComponents.Comment
{
	public class CommentList:ViewComponent
	{
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id) //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            var values = cm.GetCommentWithProduct(id);
            return View(values);
        }
    }
}
