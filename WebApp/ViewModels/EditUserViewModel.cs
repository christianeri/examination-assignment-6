using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class EditUserViewModel
    {
        public string? UserName { get; set; } = null;
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public string? Email { get; set; } = null;


        public ICollection<UserAddressEntity> Addresses { get; set; } = new HashSet<UserAddressEntity>();
        public string? Role { get; set; }



        //public static implicit operator ProductEntity(AddProductViewModel model)
        //{
        //    var productEntity = new ProductEntity
        //    {
        //        ArticleNumber = model.ArticleNumber,
        //        Brand = model.Brand,
        //        Category = model.Category,
        //        Name = model.Name,
        //        Description = model.Description,
        //        Price = model.Price
        //    };

        //    if (model.Image != null)
        //        productEntity.ImageUrl = $"{model.ArticleNumber}_{model.Image?.FileName}";

        //    return productEntity;
        //}
    }
}

