﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Dtos;
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
        public async Task<IActionResult> Index()
        {
            return View();
        }




        [Authorize]
        public async Task<IActionResult> Details(string selectedUser)
        {
            var model = new UserViewModel
            {
                UserItem = await _userService.GetUserByUserNameAsync(selectedUser),
            };
            return View(model);
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
            
            var model = new UpdateUserViewModel
            {
                UserItem = await _userService.GetUserAsync(selectedUser),
            };
            return View(model);
        }





        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Update(UserRoleDto entity)
        {
            await _userService.UpdateUserRoleAsync(entity);

            return RedirectToAction("index", "");
        }
    }
}
