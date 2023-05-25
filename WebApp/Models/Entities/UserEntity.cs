using Microsoft.AspNetCore.Identity;

#region 4m9W1a0T6SU
namespace WebApp.Models.Entities
{
    public class UserEntity : IdentityUser
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        //public int AddressId { get; set; }
        //public AddressEntity Address { get; set; } = null!;
        public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();



        //public static implicit operator UserDto(UserEntity entity)
        //{
        //    return new UserDto
        //    {
        //        FirstName = entity.FirstName,
        //        LastName = entity.LastName,
        //        ImageUrl = entity.ImageUrl,
        //        UserName = entity.UserName,
        //        Email = entity.Email,
        //        PhoneNumber = entity.PhoneNumber
        //    };
        //}
    }
}
#endregion