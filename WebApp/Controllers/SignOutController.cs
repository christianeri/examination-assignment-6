using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class SignOutController : Controller
    {

        private readonly AuthService _authService;
        public SignOutController(AuthService authService)
        {
            _authService = authService;
        }




        [Authorize]
        public async Task<IActionResult> Index()
        {
            if (await _authService.SignOutAsync(User))
                    return LocalRedirect("/");

            return RedirectToAction("Index", "Home");
        }
    }
}
