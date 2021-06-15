using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PsDevs.Data
{
    public interface IRepositoryPattern<T>
    {
        public void Create(T entity);
        public void Delete(T entity);
        public void Update(T entity);
        public void Save();
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        public IEnumerable<T> FindAll();
        public T FindById(int id);
    }
}
