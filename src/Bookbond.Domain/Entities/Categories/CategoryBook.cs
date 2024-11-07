using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Books;

namespace Bookbond.Domain.Entities.Categories;

public class CategoryBook : BaseEntity
{
    public long CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;

    public long BookId { get; set; }
    public virtual Book Book { get; set; } = null!;
}
