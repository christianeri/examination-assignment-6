using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SignUpController : Controller
    {


        private readonly AuthService _authService;
        public SignUpController(AuthService authService)
        {
            _authService = authService;
        }





        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.SignUpAsync(model))
                    return RedirectToAction("index", "signin");
                
                ModelState.AddModelError("", "A user with that e-mail address already exists");

            }
            return View(model);
        }
    }
}

