﻿using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forDataContext
{
    public class ProductRepo : DataRepository<ProductEntity>
    {
        public ProductRepo(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
