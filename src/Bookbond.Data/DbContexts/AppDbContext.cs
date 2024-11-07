
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

    //OnModelCreating method is used to configure the database schema with hasKey, hasMany, hasOne, etc.
    //In DataBase need write as snake_case but in C# we use PascalCase

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().ToTable("categories");
        modelBuilder.Entity<Category>().HasKey(c => c.Id);
        modelBuilder.Entity<Category>().Property(c => c.Id).HasColumnName("id");
        modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("name").HasMaxLength(100).IsRequired();

        modelBuilder.Entity<CategoryBook>().ToTable("category_books");
        modelBuilder.Entity<CategoryBook>().HasKey(cb => cb.Id);
        modelBuilder.Entity<CategoryBook>().Property(cb => cb.Id).HasColumnName("id");

        modelBuilder.Entity<Book>().ToTable("books");
        modelBuilder.Entity<Book>().HasKey(b => b.Id);
        modelBuilder.Entity<Book>().Property(b => b.Id).HasColumnName("id");
        modelBuilder.Entity<Book>().Property(b => b.Title).HasColumnName("title").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Book>().Property(b => b.Description).HasColumnName("description").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Book>().Property(b => b.AuthorId).HasColumnName("author_id");

        modelBuilder.Entity<Author>().ToTable("authors");
        modelBuilder.Entity<Author>().HasKey(a => a.Id);
        modelBuilder.Entity<Author>().Property(a => a.Id).HasColumnName("id");

        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("id");

        modelBuilder.Entity<Bookshelf>().ToTable("bookshelves");
    }

}
