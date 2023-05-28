using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WebApp.Models.Entities;
//using WebApp.Models.Identity;

namespace WebApp.Contexts
{
    public class IdentityContext: IdentityDbContext<UserEntity> //4m9W1a0T6SU
    {

        public DbSet<AddressEntity> AppAddresses { get; set; }
        public DbSet<UserAddressEntity> AppUserAddresses { get; set; }

        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }



        #region 4m9W1a0T6SU
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //var userId = Guid.NewGuid().ToString();
            //var roleId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole {
                    Id = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new IdentityRole
                {
                    Id = "b06e0094-cb96-4f6f-9fe9-3322d943793f",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                });

            var passwordHasher = new PasswordHasher<UserEntity>();
            var userEntity = new UserEntity
            {
                Id = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                UserName = "admin@system.com",
                NormalizedUserName = "ADMIN@SYSTEM.COM",
                Email = "admin@system.com",
                NormalizedEmail = "ADMIN@SYSTEM.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            userEntity.PasswordHash = passwordHasher.HashPassword(userEntity, "P@ssw0rd");
            builder.Entity<UserEntity>().HasData(userEntity);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = userEntity.Id,
                RoleId = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a"
            });
        }
        #endregion
    }
}
