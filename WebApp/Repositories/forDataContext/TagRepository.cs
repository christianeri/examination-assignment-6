using WebApp.Contexts;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace WebApp.Repositories.forDataContext
{
    public class TagRepository : DataRepository<TagEntity>
    {
        public TagRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
