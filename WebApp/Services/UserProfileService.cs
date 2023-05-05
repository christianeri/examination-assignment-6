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





        public async Task<UserEntity> GetUserProfileAsync(string userId)
        {
            var userEntity = await _userContext.AppUsers.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId);
            return userEntity!;
        }
    }
}
