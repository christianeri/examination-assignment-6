using Microsoft.AspNetCore.Identity;
using WebApp.Models.Entities;
using WebApp.ViewModels;
using WebApp.Contexts;
using System.Security.Claims;

namespace WebApp.Services
{
    public class AuthService
    {

        private readonly UserContext _userContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AuthService(UserContext userContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userContext = userContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }




        //www.youtube.com/watch?v=fQTe81VSxj8 01:10
        public async Task<bool> SignUpAsync(SignUpViewModel model)
        {
            try
            {
                IdentityUser identityUser = model;


                await _userManager.CreateAsync(identityUser, model.Password);


                UserProfileEntity userProfileEntity = model;
                userProfileEntity.UserId = identityUser.Id;

                _userContext.UserProfiles.Add(userProfileEntity);
                await _userContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
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
