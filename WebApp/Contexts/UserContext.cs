using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
using WebApp.Models.Identity;

namespace WebApp.Contexts
{
    public class UserContext: IdentityDbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<UserProfileEntity> UserProfiles { get; set; }
    }
}
