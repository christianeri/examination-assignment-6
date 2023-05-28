using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Migrations.User;
using WebApp.Models.Dtos;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;
using WebApp.Repositories.forIdentityContext;

namespace WebApp.Services
{
    public class UserService
    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserService(UserManager<UserEntity> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
        
        
        public async Task<UserDto> GetUserAsync(string selectedUserId)
        {
            var userEntity = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == selectedUserId);
            var role = await _userManager.GetRolesAsync(userEntity);

            var userDto = new UserDto
            {
                Id = selectedUserId,
                UserName = userEntity.UserName,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                ImageUrl = userEntity.ImageUrl,
                Email = userEntity.Email,
                Roles = role.ToList()
            };
            return userDto;
        }




        public async Task UpdateUserRoleAsync(UserRoleDto entity)
        {

            var roles = new List<SelectListItem>();
            foreach (var role in await _roleManager.Roles.ToListAsync())
            {
                roles.Add(new SelectListItem
                {
                    Value = role.Id,
                    Text = role.Name
                });
            }
            //string role;
            var currentRole = roles.FirstOrDefault(x => x.Text != entity.SelectedRoleName);
            string normalized = currentRole.Text.ToUpper();

            var user = await _userManager.FindByIdAsync(entity.UserId);
            if (user != null)
            {
                var resultRemove = await _userManager.RemoveFromRoleAsync(user, normalized);
                var resultAdd = await _userManager.AddToRoleAsync(user, entity.SelectedRoleName);
            }

        }


        //public async Task<UserRoleEntity> UpdateUserRoleAsync(UserRoleEntity entity)
        //{
        //    var result = await _userRoleRepo.UpdateAsync(entity);
        //    return result;
        //}
    }
}
