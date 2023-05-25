using WebApp.Contexts;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace WebApp.Repositories.forDataContext
{
    public class TagRepo : DataRepository<TagEntity>
    {
        public TagRepo(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
