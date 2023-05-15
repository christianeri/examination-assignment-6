using Microsoft.AspNetCore.Identity;
using WebApp.ViewModels;
using WebApp.Contexts;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Identity;
using System.Linq.Expressions;
using WebApp.Models.Entities;

namespace WebApp.Services
{
    public class AuthenticationService
    {


        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AddressService _addressService;

        public AuthenticationService(UserManager<AppUser> userManager, AddressService addressService, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _addressService = addressService;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }






        //www.youtube.com/watch?v=yGpybKyQlHo 02:07
        public async Task<bool> UserExitsAsync(Expression<Func<AppUser, bool>> expression)
        {
            //return await _userManager.Users.AnyAsync(x => x.Email == model.Email);  
            return await _userManager.Users.AnyAsync(expression);  
        }





        //www.youtube.com/watch?v=fQTe81VSxj8 01:10
        public async Task<bool> SignUpAsync(SignUpViewModel model)
        {
     
            //02:36
            //await _seedService.SeedRoles();
            //var roleName = "user";
            //02:40 ff 
            //if (!await _userManager.Users.AnyAsync())
            //    roleName = "admin";


            AppUser appUser = model;
            var roleName = "User";

            if(!await _roleManager.Roles.AnyAsync())
            {
                await _roleManager.CreateAsync(new IdentityRole("Administrator"));
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            if(!await _userManager.Users.AnyAsync())
                roleName = "Administrator";

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, roleName);

                var addressEntity = await _addressService.GetOrCreateAsync(model);
                if(addressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser, addressEntity);
                    return true;
                }
            }
            return false;
        }





        //www.youtube.com/watch?v=fQTe81VSxj8 01:33
        public async Task<bool> SignInAsync(SignInViewModel model)
        {


            var appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == model.Email);
            if(appUser != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                return result.Succeeded;
            }
            return false;

        }





        public async Task<bool> SignOutAsync(ClaimsPrincipal user)
        {
            await _signInManager.SignOutAsync();
            return _signInManager.IsSignedIn(user);
        }
    }
}
