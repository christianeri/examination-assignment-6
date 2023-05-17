using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class GridCollectionItemViewModel
    {
        public string ArticleNumber { get; set; }

        public string? ImageUrl { get; set; }

        public string Category { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }


        public ICollection<ProductTagEntity> ProductTags { get; set; }
    }
}
