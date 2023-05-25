using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forDataContext
{
    public class ProductTagRepo : DataRepository<ProductTagEntity>
    {
        public ProductTagRepo(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
