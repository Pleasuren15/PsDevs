using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PsDevs.Data
{
    public class CRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public AppDbContext _appDbContext { get; set; }
        public CRepositoryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _appDbContext.Set<T>().Where(expression);
        }

        public IEnumerable<T> FindAll()
        {
            return _appDbContext.Set<T>();
        }

        public T FindById(int id)
        {
            return _appDbContext.Set<T>().Find(id);
        }
    }
}
