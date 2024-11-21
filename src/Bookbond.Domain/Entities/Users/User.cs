using Bookbond.Domain.Common;
using Bookbond.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbond.Domain.Entities.Users;

public class User : Auditable
{
    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name should contain only alphabets")]
    public string FirstName { get; set; } = null!;

    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name should contain only alphabets")]
    public string LastName { get; set; } = null!;

    [Required]
    [Column(TypeName = "date")]
    public DateTime DateOfBirth { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string Username { get; set; } = null!;

    public bool IsEmailVerified { get; set; } = false;

    public bool IsPhoneVerified { get; set; } = false;

    public string PasswordHash { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string? ProfilePicture { get; set; }
    
    public UserRole Role { get; set; } = UserRole.User;
}
