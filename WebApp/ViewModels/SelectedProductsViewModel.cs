using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class SelectedProductsViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
        //public List<string> AssociatedTags { get; set; }
    }
}
