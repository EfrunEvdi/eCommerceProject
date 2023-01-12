using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.ViewComponents.SubCategory
{
    public class SubCategoryList : ViewComponent
    {
        SubCategoryManager scm = new SubCategoryManager(new EfSubCategoryRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values=scm.TGetList(id);    
            return View(values);
        }
    }
}
