
using Bookbond.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Service.DTOs.Accounts;

public record AccountCreateDTO
{

    [Required, MinLength(3)]
    public string Firstname { get; set; } = string.Empty;

    [Required, MinLength(3)]
    public string Lastname { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;


    public static implicit operator User(AccountCreateDTO accountCreateDto)
    {
        return new User()
        {
            FirstName = accountCreateDto.Firstname,
            LastName = accountCreateDto.Lastname,
            Email = accountCreateDto.Email,
        };
    }
}
