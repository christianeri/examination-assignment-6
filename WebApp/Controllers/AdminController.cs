using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Contexts;
using WebApp.Models.Identity;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        //private readonly UserContext _userContext;

        public AdminController(UserManager<AppUser> userManager)//, UserContext userContext)
        {
            _userManager = userManager;
            //_userContext = userContext;
        }


        //private readonly UserService _userService;
        //public AdminController(UserService userService)
        //{
        //    _userService = userService;
        //}





        //www.youtube.com/watch?v=yGpybKyQlHo 03:24
        [Authorize(Roles = "administrator")]
        public async Task<IActionResult> Index()
        {
            return View();
        }





        public async Task<IActionResult> Users()
        {
            var usersX = _userManager.Users;

            var users = _userManager.Users.Select(c => new AllUsersViewModel()
            {
                UserName = c.UserName,
                Email = c.Email,
                Role = string.Join(",", _userManager.GetRolesAsync(c).Result.ToArray())
            }).ToList();


            //List<string> usersRoles = new List<string>();

            //foreach (var user in users)
            //{
            //    var usersRoles.Add(_userManager.GetRolesAsync(user));
            //}
            
            return View(users);
        }


    }
}
