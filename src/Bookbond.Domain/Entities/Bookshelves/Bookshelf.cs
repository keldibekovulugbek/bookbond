
using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Users;

namespace Bookbond.Domain.Entities.Bookshelves;

public class Bookshelf : BaseEntity
{
    public string Name { get; set; } = null!;

    public long UserId { get; set; }
    public virtual User User { get; set; } = null!;
}
