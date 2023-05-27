﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {

        private readonly UserService _userService;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UsersController(UserService userService, RoleManager<IdentityRole> roleManager)
        {
            _userService = userService;
            _roleManager = roleManager;
        }





        [Authorize]
        public IActionResult Index()
        {
            return View();
        }        
        
        

        
        
        [Authorize]
        public async Task<IActionResult> Edit(string selectedUser)
        {
            var roles = new List<SelectListItem>();
            foreach (var role in await _roleManager.Roles.ToListAsync())
            {
                roles.Add(new SelectListItem
                {
                    Value = role.Id,
                    Text = role.Name
                });
            }
            ViewBag.AllRoles = roles;
            
            var model = new UserDetailsViewModel
            {
                UserItem = await _userService.GetUserAsync(selectedUser),
            };
            return View(model);
        }
    }
}
