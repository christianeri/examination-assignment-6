using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; } = "img/placeholders/270x295.svg";
        public string? Category { get; set; } = null!;        
        public string? Tag { get; set; } = null!;
        public string? Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}
