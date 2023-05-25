using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using WebApp.Models.Entities;
//using WebApp.Models.Identity;
using WebApp.Services;

namespace WebApp.Factories
{
    public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory</*AppUser*/UserEntity>
    {


        private readonly UserManager</*AppUser*/UserEntity> _userManager;
        public CustomClaimsPrincipalFactory(UserManager</*AppUser*/UserEntity> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
            _userManager = userManager;
        }





        //protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(/*AppUser*/UserEntity user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);
            //claimsIdentity.AddClaim(new Claim("DisplayName", $"{user.FirstName} {user.LastName}"));

            ((ClaimsIdentity)claimsIdentity).AddClaims(new[]
    {
            new Claim("DisplayName", $"{user.FirstName} {user.LastName}".ToString()),
            new Claim("FirstName", user.FirstName.ToString()),
            new Claim("LastName", user.LastName.ToString()),
            new Claim("Email", user.Email.ToString()),
            new Claim("ImageUrl", user.ImageUrl.ToString())
             });

            var roles = await UserManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claimsIdentity.AddClaim(new Claim(role, role.ToString()));
            }

            return claimsIdentity;
        }
    }
}
