using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Models.Dtos;

namespace WebApp.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public string ArticleNumber { get; set; } = null!;

        public int BrandId { get; set; }

        //public int CategoryId { get; set; }
        //public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public string Name { get; set; } = null!;
        
        [Column(TypeName = "money")]
        public decimal Price { get; set; } = 0;


        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();

 



        public static implicit operator ProductDto(ProductEntity entity)
        {
            return new ProductDto
            {
                ArticleNumber = entity.ArticleNumber,
                BrandId = entity.BrandId,
                //CategoryId = entity.CategoryId,
                Description = entity?.Description,
                ImageUrl = entity?.ImageUrl,
                Name = entity.Name,
                Price = entity.Price
            };
        }
    }
}
