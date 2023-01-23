using eCommerceProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerceProject.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel signUpViewModel,Trader trader)
        {
            if (!signUpViewModel.IsAcceptTheContract)
            {
                ModelState.AddModelError("IsAcceptTheContract", "Kullanım koşullarını kabul etmeniz gerekmektedir");
                return View(signUpViewModel);
            }
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = signUpViewModel.Mail,
                    UserName = signUpViewModel.UserName,
                    NameSurname = signUpViewModel.NameSurname
                   
                };
                var result = await _userManager.CreateAsync(user, signUpViewModel.Password);

                if (result.Succeeded)
                {
                    //trader.MailTrader = signUpViewModel.Mail;
                    return RedirectToAction("Index", "LoginUser");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(signUpViewModel);


        }
    }
}
