using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PsDevs.Data
{
    public interface IRepositoryBase<T>
    {
       void Create(T entity);
       void Delete(T entity);
       void Update(T entity);
       void Save();
       IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
       IEnumerable<T> FindAll();
       T FindById(int id);
    }
}
