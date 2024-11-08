using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces;
using Bookbond.DataAccess.Interfaces.Authors;
using Bookbond.DataAccess.Interfaces.Books;
using Bookbond.DataAccess.Interfaces.Bookshelves;
using Bookbond.DataAccess.Interfaces.Categories;
using Bookbond.DataAccess.Interfaces.Reviews;
using Bookbond.DataAccess.Interfaces.Users;
using Bookbond.DataAccess.Repositories.Authors;
using Bookbond.DataAccess.Repositories.Books;
using Bookbond.DataAccess.Repositories.Bookshelves;
using Bookbond.DataAccess.Repositories.Categories;
using Bookbond.DataAccess.Repositories.Reviews;
using Bookbond.DataAccess.Repositories.Users;

namespace Bookbond.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public IAuthorRepository Authors { get; }

        public IBookRepository Books { get; }
        
        public IBookshelfRepository Bookshelves { get; }
        public IBookshelfBookRepository BookshelfBooks { get; }

        public ICategoryRepository Categories { get; }
        public ICategoryBookRepository CategoryBooks { get; }

        public IReviewRepository Reviews { get; }

        public IUserRepository Users { get; }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => await _dbContext.SaveChangesAsync(cancellationToken);
        
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;

            Authors = new AuthorRepository(_dbContext);

            Books = new BookRepository(_dbContext);

            Bookshelves = new BookshelfRepository(_dbContext);
            BookshelfBooks = new BookshelfBookRepository(_dbContext);

            Categories = new CategoryRepository(_dbContext);
            CategoryBooks = new CategoryBookRepository(_dbContext);

            Reviews = new ReviewRepository(_dbContext);

            Users = new UserRepository(_dbContext);
        }
    }
}
