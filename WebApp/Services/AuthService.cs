using Microsoft.AspNetCore.Identity;
using WebApp.ViewModels;
using WebApp.Contexts;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Services
{
    public class AuthService
    {

        //private readonly UserContext _userContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly SeedService _seedService;
        private readonly AddressService _addressService;
        public AuthService(UserContext userContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, SeedService seedService, RoleManager<IdentityRole> roleManager, AddressService addressService)
        {
            //_userContext = userContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _seedService = seedService;
            _addressService = addressService;
        }



        //www.youtube.com/watch?v=yGpybKyQlHo 02:07
        public async Task<bool> UserExitsAsync(SignUpViewModel model)
        {
            return await _userManager.Users.AnyAsync(x => x.Email == model.Email);  
        }




        //www.youtube.com/watch?v=fQTe81VSxj8 01:10
        public async Task<bool> SignUpAsync(SignUpViewModel model)
        {
     
            //02:36
            await _seedService.SeedRoles();
            var roleName = "user";
            //02:40 ff 
            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";



            IdentityUser identityUser = model;
            var result = await _userManager.CreateAsync(identityUser, model.Password);
            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(identityUser, roleName);
                
                
                var addressEntity = await _addressService.GetOrCreateAsync(model);
                if(addressEntity != null)
                {
                    await _addressService.AddAddressAsync(identityUser, addressEntity);
                }

                return true;
            }
            return false;
        }





        //www.youtube.com/watch?v=fQTe81VSxj8 01:33
        public async Task<bool> SignInAsync(SignInViewModel model)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                return result.Succeeded;
            }
            catch
            {
                return false;
            }
        }





        public async Task<bool> SignOutAsync(ClaimsPrincipal user)
        {
            await _signInManager.SignOutAsync();
            return _signInManager.IsSignedIn(user);
        }
    }
}
