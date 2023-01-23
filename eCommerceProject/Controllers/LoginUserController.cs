using eCommerceProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerceProject.Controllers
{

    [AllowAnonymous]

    public class LoginUserController : Controller
	{
        private readonly SignInManager<AppUser> _signInManager;

        public LoginUserController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
          
            if (ModelState.IsValid)
            {
                
                var result = await _signInManager.PasswordSignInAsync(  p.username, p.password, false,true);

                if (result.Succeeded)
                {
                    return RedirectToAction("MyProfile", "Profile");
                }
                else
                {
                    return RedirectToAction("Index", "LoginUser");
                }

            }
            return View();
            


        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "LoginUser");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
