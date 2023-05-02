using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Identity;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SignUpController : Controller
    {

        private readonly UserManager<CustomIdentityUser> _userManager;
        public SignUpController(UserManager<CustomIdentityUser> userManager)
        {
            _userManager = userManager;
        }





        //private readonly AuthService _auth;
        //public SignUpController(AuthService auth)
        //{
        //    _auth = auth;
        //}





        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }





        [HttpPost]
        public async Task<IActionResult> Index(SignUpViewModel signupViewModel)
        {
            if (ModelState.IsValid)
            {

                if (await _userManager.FindByNameAsync(signupViewModel.Email) == null)
                {
                    var result = await _userManager.CreateAsync(signupViewModel, signupViewModel.Password);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "Home");


                }
                ModelState.AddModelError("", "A user with that e-mail address already exists");
            }
            return View(signupViewModel);
        }
    }
}

