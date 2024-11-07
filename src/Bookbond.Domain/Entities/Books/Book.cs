
using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Authors;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Domain.Entities.Books;

public class Book : Auditable
{
    [Required]
    public string Title { get; set; } = null!;
    
    [Required] 
    public string Description { get; set; } = null!;
    
    [Required] 
    public string ISBN { get; set; } = null!;
    
    public string? CoverImage { get; set; }
    
    public long AuthorId { get; set; }
    
    public virtual Author Author { get; set; } = null!;
    
    [Required] 
    public string Publisher { get; set; } = null!;
    
    public DateTime PublishedOn { get; set; }
    
    public int TotalPages { get; set; }
    
    [Required] 
    public string Language { get; set; } = null!;
}
