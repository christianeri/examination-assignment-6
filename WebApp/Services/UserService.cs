﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Dtos;
using WebApp.Models.Entities;
using WebApp.Repositories.forIdentityContext;

namespace WebApp.Services
{
    public class UserService
    {

        private readonly UserManager<UserEntity> _userManager;
        //private readonly UserRoleRepo _userRoleRepo;
        public UserService(UserManager<UserEntity> userManager/*, UserRoleRepo userRoleRepo*/)
        {
            _userManager = userManager;
            //_userRoleRepo = userRoleRepo;
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
            var result = await _userManager.FindByIdAsync(entity.UserId);
            if (result != null)
            {
                await _userManager.RemoveFromRoleAsync(result, entity.RoleName);
                await _userManager.AddToRoleAsync(result, entity.RoleName);
            }

        }


        //public async Task<UserRoleEntity> UpdateUserRoleAsync(UserRoleEntity entity)
        //{
        //    var result = await _userRoleRepo.UpdateAsync(entity);
        //    return result;
        //}
    }
}
