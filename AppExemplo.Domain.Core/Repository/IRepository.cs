using AppExemplo.Domain.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AppExemplo.Domain.Core.Repository
{
    public interface IRepository<TEntity, TKey>
        where TEntity : IEntity<TKey>
    {
        TEntity GetById(TKey key);
        TEntity[] GetAll();
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> expression);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}
