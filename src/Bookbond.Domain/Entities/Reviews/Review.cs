

using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Books;
using Bookbond.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Domain.Entities.Reviews;

public class Review : BaseEntity
{
    public long UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public long BookId { get; set; }
    public virtual Book Book { get; set; } = null!;

    public string Content { get; set; } = null!;

    [Range(1, 5)]
    public int Rating { get; set; }
}
