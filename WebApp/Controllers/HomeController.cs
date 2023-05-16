using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var viewModel = new HomeIndexViewModel() 
            {
                BestCollection = new GridCollectionViewModel
                {
                    Title = "Best Collection",
                    Categories = new List<string>
                    {
                        "All", "Bag", "Beauty", "Decoration", "Dress", "Esstentials", "Mobile", "Laptops", "Interior"   
                    },
                    GridItems = new List<GridCollectionItemViewModel> 
                    {
                        new GridCollectionItemViewModel
                        {   Id = "1", Title = "Apple Watch Collection", Price = 10, ImageUrl = "img/placeholders/270x295.svg"   },
                        new GridCollectionItemViewModel
                        {   Id = "2", Title = "Apple Watch Collection", Price = 20, ImageUrl = "img/placeholders/270x295.svg"   },
                        new GridCollectionItemViewModel
                        {   Id = "3", Title = "Apple Watch Collection", Price = 30, ImageUrl = "img/placeholders/270x295.svg"   },
                        new GridCollectionItemViewModel
                        {   Id = "4", Title = "Apple Watch Collection", Price = 40, ImageUrl = "img/placeholders/270x295.svg"   },
                        new GridCollectionItemViewModel
                        {   Id = "5", Title = "Apple Watch Collection", Price = 50, ImageUrl = "img/placeholders/270x295.svg"   },
                        new GridCollectionItemViewModel
                        {   Id = "6", Title = "Apple Watch Collection", Price = 60, ImageUrl = "img/placeholders/270x295.svg"   },
                        new GridCollectionItemViewModel
                        {   Id = "7", Title = "Apple Watch Collection", Price = 70, ImageUrl = "img/placeholders/270x295.svg"   },                        
                        new GridCollectionItemViewModel
                        {   Id = "8", Title = "Apple Watch Collection", Price = 80, ImageUrl = "img/placeholders/270x295.svg"   }
                    }
                },
                SummerCollection = new GridCollectionViewModel
                {
                    Title = "Summer Collection"
                }
            };

            return View(viewModel);
        }
    }
}
