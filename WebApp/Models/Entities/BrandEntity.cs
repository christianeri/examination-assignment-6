using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Entities
{
    public class BrandEntity
    {
        [Key]
        public int Id { get; set; }

        public string? BrandName { get; set; }

        public ICollection<ProductEntity> Products = new HashSet<ProductEntity>();
    }
}
