using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Models.Dtos;

namespace WebApp.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public string ArticleNumber { get; set; }

        public string? ImageUrl { get; set; }

        public string Category { get; set; } = null!;

        public string Name { get; set; } = null!;
        
        public string? Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; } 


        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();





        //public static implicit operator ProductModel(ProductEntity entity)
        //{
        //    return new ProductModel
        //    {
        //        ArticleNumber = entity.ArticleNumber,
        //        ImageUrl = entity?.ImageUrl,
        //        Category = entity?.Category,
        //        Name = entity?.Name,
        //        Description = entity?.Description,
        //        Price = entity?.Price
        //    };
        //}        


        public static implicit operator ProductDto(ProductEntity entity)
        {
            return new ProductDto
            {
                ArticleNumber = entity.ArticleNumber,
                ImageUrl = entity?.ImageUrl,
                Category = entity?.Category,
                Name = entity?.Name,
                Description = entity?.Description,
                Price = entity.Price
            };
        }
    }
}
