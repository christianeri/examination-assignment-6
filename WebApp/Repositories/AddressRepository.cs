using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories
{
    public class AddressRepository : Repository<AddressEntity>
    {
        public AddressRepository(UserContext userContext) : base(userContext)
        {
        }
    }
}
