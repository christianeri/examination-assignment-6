using WebApp.Contexts;

namespace WebApp.Repositories.forDataContext
{
    public class FilteredProductsRepo : DataRepository<List<string>>
    {
        public FilteredProductsRepo(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
