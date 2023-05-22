using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forUserContext
{
    public class AddressRepository : IdenitityRepository<AddressEntity>
    {
        public AddressRepository(IdentityContext userContext) : base(userContext)
        {
        }
    }
}
