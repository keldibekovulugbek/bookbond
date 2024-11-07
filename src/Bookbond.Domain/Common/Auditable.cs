using Bookbond.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Domain.Common;

public class Auditable : BaseEntity
{
    public User? CreatedBy { get; set; }
    [Required]
    public DateTime Created { get; set; }
    public User? LastModifiedBy { get; set; }
    public DateTime? LastModified { get; set; }
}
