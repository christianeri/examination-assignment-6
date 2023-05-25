using Microsoft.AspNetCore.Identity;
using WebApp.ViewModels;
using WebApp.Contexts;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
//using WebApp.Models.Identity;
using System.Linq.Expressions;
using WebApp.Models.Entities;

namespace WebApp.Services
{
    public class AuthenticationService
    {


        //private readonly UserManager<AppUser> _userManager;
        private readonly UserManager<UserEntity> _userManager;
        //private readonly SignInManager<AppUser> _signInManager;        
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AddressService _addressService;

        public AuthenticationService(UserManager</*AppUser*/UserEntity> userManager, AddressService addressService, SignInManager</*AppUser*/UserEntity> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _addressService = addressService;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }






        //www.youtube.com/watch?v=yGpybKyQlHo 02:07
        public async Task<bool> UserExitsAsync(Expression<Func</*appUser,*/UserEntity, bool>> expression)
        {
            //return await _userManager.Users.AnyAsync(x => x.Email == model.Email);  
            return await _userManager.Users.AnyAsync(expression);  
        }




        //www.youtube.com/watch?v=4m9W1a0T6SU 01:33
        //www.youtube.com/watch?v=fQTe81VSxj8 01:10
        public async Task<bool> SignUpAsync(SignUpViewModel model)
        {
            //AppUser appUser = model;
            UserEntity userEntity = model;


            #region obsolete
            //02:36
            //await _seedService.SeedRoles();
            //var roleName = "user";
            //02:40 ff 
            //if (!await _userManager.Users.AnyAsync())
            //    roleName = "admin";
            #endregion


            var roleName = "user";
            if(!await _roleManager.Roles.AnyAsync())
            {
                await _roleManager.CreateAsync(new IdentityRole("administrator"));
                await _roleManager.CreateAsync(new IdentityRole("user"));
            }
            if(!await _userManager.Users.AnyAsync())
                roleName = "administrator";
            


            var result = await _userManager.CreateAsync(/*appUser,*/userEntity, model.Password);
            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(/*appUser,*/userEntity, roleName);

                var addressEntity = await _addressService.GetOrCreateAsync(model);
                if(addressEntity != null)
                {
                    await _addressService.AddAddressAsync(/*appUser,*/userEntity, addressEntity);
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
