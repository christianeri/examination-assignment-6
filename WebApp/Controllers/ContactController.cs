using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ContactController : Controller
    {

        private readonly ContactService _contactService;
        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }





        public IActionResult Index()
        {
            return View();
        }





        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterContactViewModel productRegistrationViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _contactService.RegisterContactAsync(productRegistrationViewModel))
                    return RedirectToAction("Index", "Contact");

                ModelState.AddModelError("", "Something went wrong when submitting your message");

            }
            return View();
        }
    }
}
