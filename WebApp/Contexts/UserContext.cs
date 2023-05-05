using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
using WebApp.Services;

namespace WebApp.Contexts
{
    //public class UserContext: IdentityDbContext
    public class UserContext: IdentityDbContext<IdentityUser>
    {


        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<UserEntity> AppUsers { get; set; }
        public DbSet<AddressEntity> AppAddresses { get; set; }
        public DbSet<UserAddressEntity> AppUserAddresses { get; set; }


    }
}
