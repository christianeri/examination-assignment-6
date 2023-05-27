using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class ProductDetailsViewModel
    {
        public ProductDto ProductItem { get; set; }
        public List<SelectListItem> AssociatedTags { get; set; }
    }
}
