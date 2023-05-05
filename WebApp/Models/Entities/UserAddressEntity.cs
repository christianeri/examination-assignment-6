using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.Entities
{

    [PrimaryKey(nameof(UserId), nameof(AddressId))]
    public class UserAddressEntity
    {
        public string UserId { get; set; }
        //public AppUser User { get; set; }
        public UserEntity User { get; set; }


        public string AddressId { get; set; }
        public AddressEntity Address {  get; set; }
    }
}
