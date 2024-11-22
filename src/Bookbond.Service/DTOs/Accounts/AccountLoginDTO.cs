
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Service.DTOs.Accounts;

public record AccountLoginDTO
{
    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;

}
