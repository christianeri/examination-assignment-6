using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Entities
{
    public class UserEntity
    {
        [Key, ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        //public string FirstName { get; set; } = null!;
        //public string LastName { get; set; } = null!;
        //public string? StreetName { get; set; }
        //public string? PostalCode { get; set; }
        //public string? City { get; set; }

        public IdentityUser User { get; set; } = null!;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<UserAddressEntity> Addresses { get; set; } = new HashSet<UserAddressEntity>();

    }
}
