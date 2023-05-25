using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Dtos;
using WebApp.Models.Entities;

namespace WebApp.Services
{
    public class AdministratorService
    {

        private readonly UserManager<UserEntity> _userManager;
        public AdministratorService(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }





        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            var userDtos = new List<UserDto>();
            foreach(var user in await _userManager.Users.ToListAsync())
            {
                var _user = new UserDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ImageUrl = user.ImageUrl,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                };

                foreach(var role in await _userManager.GetRolesAsync(user))
                {
                    _user.Roles.Add(role);
                }
                userDtos.Add(_user);
            }
            return userDtos;
        }
    }
}
