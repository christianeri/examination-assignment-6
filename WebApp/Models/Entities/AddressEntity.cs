using Microsoft.AspNetCore.Identity;

namespace WebApp.Models.Entities
{
    public class AddressEntity: IdentityUser
    {
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public ICollection<UserAddressEntity> Users { get; set; } = new HashSet<UserAddressEntity>();   
    }
}
