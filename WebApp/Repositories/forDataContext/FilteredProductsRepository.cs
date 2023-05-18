using WebApp.Contexts;

namespace WebApp.Repositories.forDataContext
{
    public class FilteredProductsRepository : DataRepository<List<string>>
    {
        public FilteredProductsRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
