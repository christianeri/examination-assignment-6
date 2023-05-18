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





        public async Task<IActionResult> Index()
        {
            var model = new AllProductsViewModel
            {
                Products = await _productService.GetAllProductsAsync()
            };
            return View(model);
        }        
        
        
        
        
        
        public async Task<IActionResult> Details(string product)
        {
            var model = new ProductDetailsViewModel
            {
                ProductItem = await _productService.GetProductAsync(product)
            };
            return View(model);
        }





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
                //if (await _productService.CreateProductAsync(model))
                var productDto = await _productService.CreateProductAsync(model);
                if (productDto != null) 
                {
                    await _productService.AddProductTagsAsync(model, selectedTags);

                    if(model.Image != null) {await _productService.UploadImageAsync(productDto, model.Image!);}
                    
                    return RedirectToAction("register", "products");
                }
                ModelState.AddModelError("", "Something went wrong when creating product");
            }
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View(model);
        }
    }
}
