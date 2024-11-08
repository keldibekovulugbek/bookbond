
using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Books;
using Bookbond.Domain.Entities.Books;

namespace Bookbond.DataAccess.Repositories.Books;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    public BookRepository(AppDbContext context) : base(context)
    {
    }
}
