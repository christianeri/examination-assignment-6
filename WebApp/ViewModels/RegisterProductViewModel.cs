using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class RegisterProductViewModel
    {
        [Required(ErrorMessage = "Product category is required")]
        [Display(Name = "Product Category *")]
        public string Category { get; set; } = null!;
        
        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name *")]
        public string Name { get; set; } = null!;

        [Display(Name = "Product Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Product price is required")]
        [Display(Name = "Product Price *")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }



        public static implicit operator ProductEntity(RegisterProductViewModel registerProductViewModel)
        {
            return new ProductEntity
            {
                Category = registerProductViewModel.Category,
                Name = registerProductViewModel.Name,
                Description = registerProductViewModel.Description,
                Price = registerProductViewModel.Price
            };
        }
    }
}
