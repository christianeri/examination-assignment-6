using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;

namespace WebApp.Contexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }


        public DbSet<TagEntity> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagEntity>().HasData(
                new TagEntity {Id = 1, TagName = "New"},                
                new TagEntity {Id = 2, TagName = "Featured" },
                new TagEntity {Id = 3, TagName = "Popular" }
            );
        }
        public DbSet<ProductTagEntity> ProductTags { get; set; }
    }
}
