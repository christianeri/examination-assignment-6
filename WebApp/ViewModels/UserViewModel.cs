using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public UserDto UserItem { get; set; }


        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string CurrentRoleName { get; set; }
        public string SelectedRoleName { get; set; }
       
    }
}
