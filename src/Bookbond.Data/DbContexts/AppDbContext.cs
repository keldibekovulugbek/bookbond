
using Microsoft.EntityFrameworkCore;
using Bookbond.Domain.Entities.Books;
using Bookbond.Domain.Entities.Categories;
using Bookbond.Domain.Entities.Authors;
using Bookbond.Domain.Entities.Users;
using Bookbond.Domain.Entities.Bookshelves;
using Bookbond.Domain.Entities.Reviews;
namespace Bookbond.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<CategoryBook> CategoryBooks { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Bookshelf> Bookshelves { get; set; } = null!;
    public DbSet<BookshelfBook> BookshelfBooks { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

}
