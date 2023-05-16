using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductService _productService;
        private readonly TagService _tagService;
        public ProductsController(ProductService productService, TagService tagService)
        {
            _productService = productService;
            _tagService = tagService;
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






        public async Task<IActionResult> Register()
        {
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterProductViewModel model, string[] selectedTags)
        {
            if (ModelState.IsValid)
            {
                if(await _productService.CreateProductAsync(model))
                {
                    await _productService.AddProductTagsAsync(model, selectedTags);
                    return RedirectToAction("register", "products");
                }
                ModelState.AddModelError("", "Something went wrong when creating product");
            }
            ViewBag.Tags = await _tagService.GetTagsAsync(selectedTags);
            return View();
        }
    }
}
