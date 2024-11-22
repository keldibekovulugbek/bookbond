
using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Bookshelves;
using Bookbond.Domain.Entities.Bookshelves;

namespace Bookbond.DataAccess.Repositories.Bookshelves;

public class BookshelfRepository : GenericRepository<Bookshelf>, IBookshelfRepository
{
    public BookshelfRepository(AppDbContext context) : base(context)
    {
    }
}
