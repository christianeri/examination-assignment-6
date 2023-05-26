using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class AddProductViewModel
    {

        [Required(ErrorMessage = "ArticleNumber is required")]
        [Display(Name = "ArticleNumber *")]
        public string ArticleNumber { get; set; } = null!;        
        
        
        [Required(ErrorMessage = "Product category is required")]
        [Display(Name = "Product Category *")]
        public string Category { get; set; } = null!;        
        
        [Required(ErrorMessage = "Product brand is required")]
        [Display(Name = "Brand *")]
        public string Brand { get; set; } = null!;
        

        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name *")]
        public string Name { get; set; } = null!;


        [Display(Name = "Product Description")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "Product price is required")]
        [Display(Name = "Product Price *")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C4}")]
        public decimal Price { get; set; }


        [Display(Name = "Product Image")]
        [DataType(DataType.Upload)]
        public IFormFile? Image { get; set; }   



        public static implicit operator ProductEntity(AddProductViewModel model)
        {
            var productEntity = new ProductEntity
            {
                ArticleNumber = model.ArticleNumber,
                Brand = model.Brand,
                Category = model.Category,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price
            };

            if (model.Image != null)
                productEntity.ImageUrl = $"{model.ArticleNumber}_{model.Image?.FileName}";

            return productEntity;
        }
    }
}
