using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forIdentityContext
{
    public class AddressRepository : IdenitityRepository<AddressEntity>
    {
        public AddressRepository(IdentityContext userContext) : base(userContext)
        {
        }
    }
}
