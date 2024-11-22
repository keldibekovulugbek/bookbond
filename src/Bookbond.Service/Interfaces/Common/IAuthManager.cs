using Bookbond.Domain.Entities.Users;

namespace Bookbond.Service.Interfaces.Common
{
    public interface IAuthManager
    {
        public string GenerateToken(User user);
    }
}
