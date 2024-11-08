using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Categories;
using Bookbond.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookbond.DataAccess.Repositories.Categories
{
    public class CategoryBookRepository : GenericRepository<CategoryBook>, ICategoryBookRepository
    {
        public CategoryBookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
