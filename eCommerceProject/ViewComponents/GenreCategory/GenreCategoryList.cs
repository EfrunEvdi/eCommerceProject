using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.ViewComponents.GenreCategory
{
    public class GenreCategoryList : ViewComponent
    {
        GenreCategoryManager gcm = new GenreCategoryManager(new EfGenreCategoryRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = gcm.TGetList(id);
            return View(values);
        }
    }
}
