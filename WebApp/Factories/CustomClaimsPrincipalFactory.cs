using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using WebApp.Models.Identity;
using WebApp.Services;

namespace WebApp.Factories
{
    public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<AppUser>
    {


        private readonly UserManager<AppUser> _userManager;
        public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
            _userManager = userManager;
        }





        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);
            claimsIdentity.AddClaim(new Claim("DisplayName", $"{user.FirstName} {user.LastName}"));

            return claimsIdentity;
        }
    }
    //{e


    //    private readonly UserManager<AppUser> _userManager;
    //    public CustomClaimsPrincipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    //    {
    //        _userManager = userManager;
    //    }

    //    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
    //    {



    //        return claimsIdentity;
    //    }



    //private readonly UserProfileService _userProfileService;
    //public CustomClaimsPrincipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor, UserProfileService userProfileService) : base(userManager, optionsAccessor)
    //{
    //    _userProfileService = userProfileService;
    //}



    //protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
    //{
    //    var claimsIdentity = await base.GenerateClaimsAsync(user);

    //    var userProfileEntity = await _userProfileService.GetUserProfileAsync(user.Id);
    //    claimsIdentity.AddClaim(new Claim("DisplayName", $"{userProfileEntity.FirstName} {userProfileEntity.LastName}"));

    //    return claimsIdentity;
    //}
    //}
}
