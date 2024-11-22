
using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Authors;
using Bookbond.Domain.Entities.Authors;

namespace Bookbond.DataAccess.Repositories.Authors;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(AppDbContext context) : base(context)
    {
    }
}
