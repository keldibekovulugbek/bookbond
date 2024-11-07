
using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Users;

namespace Bookbond.Domain.Entities.Bookshelves;

public class Bookshelf : BaseEntity
{
    public long UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public virtual ICollection<BookshelfBook> BookshelfBooks { get; set; } = new List<BookshelfBook>();
}
