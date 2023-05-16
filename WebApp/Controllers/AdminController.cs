using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        //www.youtube.com/watch?v=yGpybKyQlHo 03:24
        //[Authorize(Roles = "administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
