﻿using Microsoft.AspNetCore.Identity;
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





        //protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
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


            return claimsIdentity;
        }
    }
}
