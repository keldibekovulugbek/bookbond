
using Bookbond.Domain.Common;
using Bookbond.Domain.Entities.Books;
using System.ComponentModel.DataAnnotations;

namespace Bookbond.Domain.Entities.Authors;

public class Author : Auditable
{
    [Required]
    public string FirstName { get; set; } = null!;
    
    [Required] 
    public string LastName { get; set; } = null!;
    
    [Required] 
    public string Biography { get; set; } = null!;
    
    public string? ProfilePicture { get; set; }
    
    [Required] 
    public string LivingYears { get; set; } = null!;
    
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
