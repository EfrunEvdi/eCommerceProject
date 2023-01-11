using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.ViewComponents.Product
{
    public class ProductList : ViewComponent
    {

        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            return View();
        }
    }
}
