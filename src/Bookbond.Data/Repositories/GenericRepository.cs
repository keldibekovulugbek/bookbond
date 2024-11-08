

using Bookbond.DataAccess.DbContexts;
using Bookbond.DataAccess.Interfaces;
using Bookbond.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bookbond.DataAccess.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected AppDbContext _dbcontext;
    protected DbSet<T> _dbSet;
    public GenericRepository(AppDbContext context)
    {
        _dbcontext = context;
        _dbSet = context.Set<T>();
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long id)
    {
        throw new NotImplementedException();
    }

    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Update(long id, T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }
}
