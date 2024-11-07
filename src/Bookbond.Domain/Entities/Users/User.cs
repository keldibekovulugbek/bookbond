using Bookbond.Domain.Common;
using Bookbond.Domain.Enums;

namespace Bookbond.Domain.Entities.Users;

public class User : Auditable
{
   public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; } = null!;
    public bool IsEmailVerified { get; set; } = false;
    public string PasswordHash { get; set; } = null!;
    public string Salt { get; set; } = null!;
    public string? ProfilePicture { get; set; }
    public UserRole Role { get; set; } = UserRole.User;
}
