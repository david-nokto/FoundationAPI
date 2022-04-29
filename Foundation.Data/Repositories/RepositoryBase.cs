using Foundation.Core.Repository;
using Foundation.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Foundation.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext db;

        public RepositoryBase(RepositoryContext db)
        {
            this.db = db;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
                db.Set<T>()
                  .AsNoTracking() :
                db.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
                db.Set<T>()
                  .Where(expression)
                  .AsNoTracking() :
                db.Set<T>()
                  .Where(expression);
        public void Create(T entity) => db.Set<T>().Add(entity);
        public void Update(T entity) => db.Set<T>().Update(entity);
        public void Delete(T entity) => db.Set<T>().Remove(entity);
    }
}
