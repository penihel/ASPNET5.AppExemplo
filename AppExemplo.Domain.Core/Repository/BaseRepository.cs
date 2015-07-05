using AppExemplo.Domain.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AppExemplo.Domain.Core.Repository
{
    public abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>
         where TEntity : IEntity<TKey>
    {
        public abstract void Delete(TEntity entity);
        public abstract TEntity[] GetAll();
        public abstract TEntity GetById(TKey key);
        public abstract IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> expression);
        public abstract void Save(TEntity entity);
    }
}
