using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T,bool>>? expression=null);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<bool>CreateAsync(T entity);
        Task<bool>UpdateAsync(T entity);
        Task<bool>DeleteAsync(T entity);


    }
}
