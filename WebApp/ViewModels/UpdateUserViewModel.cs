using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class UpdateUserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public UserDto UserItem { get; set; }


        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public string selectedRole { get; set; }



        public static implicit operator UserRoleDto(UpdateUserViewModel model)
        {
            return new UserRoleDto
            {
                UserId = model.UserItem.Id,
                RoleId = model.RoleId,
                RoleName = model.RoleName,
            };
        }
    }
}
