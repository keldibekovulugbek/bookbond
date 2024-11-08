using Bookbond.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Domain.Common;

public class Auditable : BaseEntity
{
    
    public string CreatedBy { get; set; } = null!;

    [Required]
    public DateTime Created { get; set; }

    public string LastModifiedBy { get; set; } = null!;
    
    public DateTime? LastModified { get; set; }
}
