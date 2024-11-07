
using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Authors;

namespace Bookbond.Domain.Entities.Books;

public class Book : Auditable
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public string? CoverImage { get; set; }
    public long AuthorId { get; set; }
    public virtual Author Author { get; set; } = null!;
    public string Publisher { get; set; } = null!;
    public DateTime PublishedOn { get; set; }
    public int TotalPages { get; set; }
    public string Language { get; set; } = null!;
}
