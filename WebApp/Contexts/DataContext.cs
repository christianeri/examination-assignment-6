using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp.Models.Entities;

namespace WebApp.Contexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ContactEntity> Contacts { get; set; }
    }


}
