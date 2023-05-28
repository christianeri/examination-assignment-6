using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forDataContext
{
    public class BrandRepo : DataRepository<BrandEntity>
    {
        public BrandRepo(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
