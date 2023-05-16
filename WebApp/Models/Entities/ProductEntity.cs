using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace WebApp.Models.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; } = "http://";

        public string Category { get; set; } = null!;

        public string Name { get; set; } = null!;
        
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; } 


        public ICollection<ProductTagsEntity> ProductTags { get; set; } = new HashSet<ProductTagsEntity>();





        public static implicit operator ProductModel(ProductEntity entity)
        {
            return new ProductModel
            {
                Id = entity.Id,
                ImageUrl = entity?.ImageUrl,
                Category = entity?.Category,
                Name = entity?.Name,
                Description = entity?.Description,
                Price = entity?.Price
            };
        }
    }
}
