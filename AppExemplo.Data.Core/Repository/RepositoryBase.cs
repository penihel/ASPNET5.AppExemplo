using System;
using System.Collections.Generic;
using AppExemplo.Core;
using AppExemplo.Domain.Core.Entity;
using AppExemplo.Domain.Core.Repository;
using AppExemplo.Domain.Core.FilterEntity;
using System.Data.Entity;

namespace AppExemplo.Data.Core.Repository
{
    public abstract class RepositoryBase<TDbSet, TEntity, TFilterEntity, TKey>
        : IRepository<TEntity, TFilterEntity, TKey>
        
        where TDbSet : class, new()
        where TEntity : IEntity<TKey>
        where TKey : struct
        where TFilterEntity : IFilterEntity<TKey>
        
    {

        private DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Delete(TEntity entity)
        {
            var data = entity.CopyTo<TDbSet>();

            _context.Entry(data).State = EntityState.Deleted;

        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> Query(TFilterEntity filter)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
