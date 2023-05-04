using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
using WebApp.Contexts;

namespace WebApp.Services
{
    public class UserProfileService
    {


        private readonly UserContext _userContext;
        public UserProfileService(UserContext userContext)
        {
            _userContext = userContext;
        }





        public async Task<UserProfileEntity> GetUserProfileAsync(string userId)
        {
            var userProfileEntity = await _userContext.UserProfiles.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId);
            return userProfileEntity!;
        }
    }
}
