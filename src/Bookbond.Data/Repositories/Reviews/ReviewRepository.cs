
using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces.Reviews;
using Bookbond.Domain.Entities.Reviews;

namespace Bookbond.DataAccess.Repositories.Reviews
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext context) : base(context)
        {
        }
    }
}
