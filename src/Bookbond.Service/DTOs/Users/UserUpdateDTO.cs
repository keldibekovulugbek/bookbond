
using Bookbond.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Service.DTOs.Users;

public record UserUpdateDTO
{
    public string FirstName { get; set; } = string.Empty;
 
    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; } 
    
    public string? ImageUrl { get; set; } = string.Empty;

    public DateOnly DateOfBirth { get; set; }

    public static implicit operator User(UserUpdateDTO userUpdateDto)
    {
        return new User()
        {
            FirstName = userUpdateDto.FirstName,
            LastName = userUpdateDto.LastName,
            PhoneNumber = userUpdateDto.PhoneNumber,
            ProfilePicture = userUpdateDto.ImageUrl,
            DateOfBirth = userUpdateDto.DateOfBirth
        };
    }
}
