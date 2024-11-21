using Bookbond.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookbond.Service.Interfaces.Users;

public interface IUserService
{
    Task<User> GetUserByIdAsync(Guid id);
    Task<User> GetUserByEmailAsync(string email);
    Task<User> GetUserByUsernameAsync(string username);
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid id);
    Task<IEnumerable<User>> GetUsersAsync();
    Task<IEnumerable<User>> GetUsersByRoleAsync(string role);
}
