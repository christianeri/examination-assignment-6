using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class SelectedProductsViewModel
    {
        public int Take { get; set; }
        public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
