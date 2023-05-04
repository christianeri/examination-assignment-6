using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SignInController : Controller
    {

        private readonly AuthService _authService;
        public SignInController(AuthService authService)
        {
            _authService = authService;
        }





        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.SignInAsync(model))
                    return RedirectToAction("index", "account");

                ModelState.AddModelError("", "Incorrect e-mail address or password");

            }
            return View(model);
        }
    }
}
