using WebApp.Models.Entities;

namespace WebApp.Models.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageUrl { get; set; }

        public string Email { get; set; }

        public decimal PhoneNumber { get; set; }


        //public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();
    }
}
