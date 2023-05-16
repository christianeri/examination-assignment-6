using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forDataContext
{
    public class ProductTagRepository : DataRepository<ProductTagsEntity>
    {
        public ProductTagRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
