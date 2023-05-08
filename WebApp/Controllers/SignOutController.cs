﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class SignOutController : Controller
    {


        private readonly SignInManager<IdentityUser> _signInManager;
        public SignOutController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }





        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }


        //private readonly AuthService _authService;
        //public SignOutController(AuthService authService)
        //{
        //    _authService = authService;
        //}





        //[Authorize]
        //public async Task<IActionResult> Index()
        //{
        //    if (await _authService.SignOutAsync(User))
        //            return LocalRedirect("/");

        //    return RedirectToAction("Index", "Home");
        //}
    }
}
