using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDto UserItem { get; set; }
        //public List<SelectListItem> AssociatedTags { get; set; }
    }
}
