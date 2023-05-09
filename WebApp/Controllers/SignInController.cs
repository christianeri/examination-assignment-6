using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SignInController : Controller
    {

        private readonly AuthenticationService _authService;
        public SignInController(AuthenticationService authService)
        {
            _authService = authService;
        }





        [HttpGet]
        public IActionResult Index (string ReturnUrl = null!)
        {
            var model = new SignInViewModel();
            if(ReturnUrl != null)
                return RedirectToAction("Index", "Home");
                //model.ReturnUrl = ReturnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.SignInAsync(model))
                    return LocalRedirect(model.ReturnUrl);

                ModelState.AddModelError("", "Incorrect e-mail address or password");

            }
            return View(model);
        }
    }
}
