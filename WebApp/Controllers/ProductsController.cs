using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductService _productService;
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }





        public IActionResult Index()
        {
            var viewModel = new ProductsIndexViewModel
            {
                All = new GridCollectionViewModel
                {
                    Title = "All Products",
                    Categories = new List<string> { "All", "Mobile", "Laptops" }
                }
            };
            return View(viewModel);
        }





        public IActionResult Manage()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterProductViewModel registerProductViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _productService.CreateProductAsync(registerProductViewModel))
                    return RedirectToAction("Manage", "Products");

                ModelState.AddModelError("", "Something went wrong when creating product");

            }
            return View();
        }
    }
}
