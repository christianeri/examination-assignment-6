using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SignUpController : Controller
    {


        private readonly AuthenticationService _authService;
        public SignUpController(AuthenticationService authService)
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
                ////www.youtube.com/watch?v=yGpybKyQlHo 02:06
                if (await _authService.UserExitsAsync(x => x.Email == model.Email))
                    ModelState.AddModelError("", "A user with that e-mail address already exists");
 
                
                if (await _authService.SignUpAsync(model))
                    return RedirectToAction("index", "signin");

            }
            return View(model);
        }
    }
}

