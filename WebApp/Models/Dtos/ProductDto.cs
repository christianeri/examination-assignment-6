using WebApp.Models.Entities;

namespace WebApp.Models.Dtos
{
    public class ProductDto
    {
        public string ArticleNumber { get; set; }

        public string? ImageUrl { get; set; }

        public string Category { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }


        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();
    }
}
