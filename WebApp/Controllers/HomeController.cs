using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ProductService _productService;
        private readonly TagService _tagService;
        public HomeController(ProductService productService, TagService tagService)
        {
            _productService = productService;
            _tagService = tagService;
        }





        public async Task<IActionResult> Index()
        {

            var viewModel = new HomeIndexViewModel()
            {
                BestCollection = new SelectedProductsViewModel 
                {
                    Products = await _productService.GetAllProductsAsync(8)
                }
            };
            ViewBag.Tags = await _tagService.GetTagsAsync();

            return View(viewModel);
        }
    }
}
