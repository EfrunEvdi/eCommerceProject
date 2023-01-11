using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class ProfileController : Controller
    {
        TraderManager tm = new TraderManager(new EfTraderRepository());

        public IActionResult profilim()
        {
            var values = tm.TGetList();
            return View(values);
        }
    }
}
