
using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Books;

namespace Bookbond.Domain.Entities.Categories;

public class Category : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
    
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
