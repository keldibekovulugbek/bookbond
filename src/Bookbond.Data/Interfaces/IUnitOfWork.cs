
using Bookbond.DataAccess.Interfaces.Authors;
using Bookbond.DataAccess.Interfaces.Books;
using Bookbond.DataAccess.Interfaces.Bookshelves;
using Bookbond.DataAccess.Interfaces.Categories;
using Bookbond.DataAccess.Interfaces.Reviews;
using Bookbond.DataAccess.Interfaces.Users;

namespace Bookbond.DataAccess.Interfaces;

public interface IUnitOfWork
{
    IAuthorRepository Authors { get; }

    IBookRepository Books { get; }

    IBookshelfRepository Bookshelves { get; }
    IBookshelfBookRepository BookshelfBooks { get; }

    ICategoryRepository Categories { get; }
    ICategoryBookRepository CategoryBooks { get; }

    IReviewRepository Reviews { get; }

    IUserRepository Users { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}
