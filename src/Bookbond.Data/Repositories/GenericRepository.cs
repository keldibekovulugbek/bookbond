

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
        _dbSet.Add(entity);
    }

    public void Delete(long id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
        }
    }

    public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression) 
        => _dbSet.FirstOrDefaultAsync(expression)!;

    public IQueryable<T> GetAll()
    {
        return _dbSet.AsNoTracking();
    }

    public async Task<T?> GetByIdAsync(long id)
        => await _dbSet.FindAsync(id);
    
    public void Update(long id, T entity)
    {
        entity.Id = id;
        _dbSet.Update(entity);
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression).AsNoTracking();
    }
}
