using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Users;
using Bookbond.Domain.Entities.Users;

namespace Bookbond.DataAccess.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
