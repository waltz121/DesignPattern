using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace State.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        void Add(T newEntity);
        void Remove(T entity);
    }
}
