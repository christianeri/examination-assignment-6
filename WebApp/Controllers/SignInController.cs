using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Identity;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SignInController : Controller
    {

        private readonly SignInManager<CustomIdentityUser> _signInManager;
        public SignInController(SignInManager<CustomIdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }





        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }





        [HttpPost]
        public async Task<IActionResult> Index(SignInViewModel signinViewModel)
        {

            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(signinViewModel.Email, signinViewModel.Password, false, false);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Incorrect e-mail address or password");
            }

            return View(signinViewModel);
        }
    }
}
