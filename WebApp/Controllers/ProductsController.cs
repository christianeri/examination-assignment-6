using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
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





        public async Task<IActionResult> Index()
        {
            var model = new SelectedProductsViewModel
            {
                Products = await _productService.GetAllProductsAsync()
            };
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View(model);
        }





        public async Task<IActionResult> Filtered(int[] selectedTags)
        {
            var model = new SelectedProductsViewModel
            {
                Products = await _productService.GetSelectedProductsAsync(selectedTags)
            };
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View(model);
        }        
        
        
        
        
        
        public async Task<IActionResult> Details(string product)
        {
            var model = new ProductDetailsViewModel
            {
                ProductItem = await _productService.GetProductAsync(product),
                AssociatedTags = await _tagService.GetTagsAsync(product)
            };

            return View(model);
        }




        //[Authorize]
        public async Task<IActionResult> Register()
        {
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AddProductViewModel model, string[] selectedTags)
        {
            if (ModelState.IsValid)
            {
                var productDto = await _productService.CreateProductAsync(model);
                if (productDto != null)
                {
                    await _productService.AddProductTagsAsync(model, selectedTags);

                    if (model.Image != null) { await _productService.UploadImageAsync(productDto, model.Image!); }

                    return RedirectToAction("register", "products");
                }
                ModelState.AddModelError("", "Something went wrong when creating product");
            }
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View(model);
        }
    }
}
