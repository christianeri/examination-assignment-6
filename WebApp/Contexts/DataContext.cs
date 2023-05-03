﻿using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;

namespace WebApp.Contexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<UserProfileEntity> UserProfiles { get; set; }
    }


}
