
using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Bookshelves;
using Bookbond.Domain.Entities.Bookshelves;

namespace Bookbond.DataAccess.Repositories.Bookshelves
{
    public class BookshelfBookRepository : GenericRepository<BookshelfBook>, IBookshelfBookRepository
    {
        public BookshelfBookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
