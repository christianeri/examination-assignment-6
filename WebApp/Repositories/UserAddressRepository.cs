using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories
{
    public class UserAddressRepository : Repository<UserAddressEntity>
    {
        public UserAddressRepository(UserContext userContext) : base(userContext)
        {
        }
    }
}
