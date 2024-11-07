using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Books;
using Bookbond.Domain.Enums;

namespace Bookbond.Domain.Entities.Bookshelves;

public class BookshelfBook : Auditable
{
    public long BookShelfId { get; set; }
    public virtual Bookshelf BookShelf { get; set; } = null!;

    public long BookId { get; set; }
    public virtual Book Book { get; set; } = null!;

    public BookStatus Status { get; set; } = BookStatus.WantToRead;
}