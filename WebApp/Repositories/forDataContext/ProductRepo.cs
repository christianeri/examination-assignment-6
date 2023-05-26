using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forDataContext
{
    //public class ProductRepository
    public class ProductRepo : DataRepository<ProductEntity>
    {
        public ProductRepo(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
