using WebApp.Models.Dtos;

namespace WebApp.ViewModels
{
    public class AllProductsViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
