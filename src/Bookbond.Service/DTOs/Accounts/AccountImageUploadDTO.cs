
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Service.DTOs.Accounts;

public record AccountImageUploadDTO
{
    [Required]
    [DataType(DataType.Upload)]
    public string Image { get; set; } = string.Empty;
}
