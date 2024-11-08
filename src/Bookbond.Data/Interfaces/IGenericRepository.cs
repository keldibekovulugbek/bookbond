using Bookbond.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bookbond.DataAccess.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(long id);

    IQueryable<T> GetAll();
    
    IQueryable<T> Where(Expression<Func<T,bool>> expression);

    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);

    void Add(T entity);

    Task<T> Update(long id,T entity);

    Task Delete(long id);
}
