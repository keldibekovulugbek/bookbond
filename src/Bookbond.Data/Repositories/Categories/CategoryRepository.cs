using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Categories;
using Bookbond.Domain.Entities.Categories;

namespace Bookbond.DataAccess.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
