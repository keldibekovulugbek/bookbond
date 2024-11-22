

using System.ComponentModel.DataAnnotations;

namespace Bookbond.Service.DTOs.Accounts;

public record AccountEmailVerifyDTO
{
    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Code { get; set; } = string.Empty;
}
