using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
using WebApp.Models.Identity;

namespace WebApp.Contexts
{
    public class UserContext: IdentityDbContext<AppUser>
    {


        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        //public DbSet<UserEntity> AppUsers { get; set; }
        public DbSet<AddressEntity> AppAddresses { get; set; }
        public DbSet<UserAddressEntity> AppUserAddresses { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var userId = Guid.NewGuid().ToString();
            var roleId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole {
                    Id = roleId,
                    Name = "SystemAdministrator",
                    NormalizedName = "SYSTEMADMINISTRATOR"
                });

            var passwordHasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = userId,
                FirstName = " ",
                LastName = " ",
                UserName = "admin@system.com",
                NormalizedUserName = "ADMIN@SYSTEM.COM",
                Email = "admin@system.com",
                ImageUrl = " ",
                PasswordHash = passwordHasher.HashPassword(null, "P@ssw0rd"),
                
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId,
            });
        }*/
    }
}
