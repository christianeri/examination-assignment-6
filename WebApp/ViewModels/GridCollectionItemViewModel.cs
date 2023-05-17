using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class GridCollectionItemViewModel
    {
        public string Id { get; set; }

        public string? ImageUrl { get; set; }

        public string Category { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }


        public ICollection<ProductTagEntity> ProductTags { get; set; }
    }
}
