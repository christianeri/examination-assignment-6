using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forUserContext
{
    public class UserAddressRepository : IdenitityRepository<UserAddressEntity>
    {
        public UserAddressRepository(IdentityContext userContext) : base(userContext)
        {
        }
    }
}
