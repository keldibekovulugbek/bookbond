
using Bookbond.Domain.Common;

namespace Bookbond.Domain.Entities.Authors;

public class Author : Auditable
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Biography { get; set; } = null!;

}
