using AppExemplo.Core;
using AppExemplo.Domain.Core.Entity;
using AppExemplo.Domain.Core.FilterEntity;
using AppExemplo.Domain.Core.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AppExemplo.Data.Core.Repository
{
    public abstract class RepositoryBase<TDbSet, TEntity, TFilterEntity, TKey>
        : IRepository<TEntity, TFilterEntity, TKey>

        where TDbSet : class, new()
        where TEntity : class, IEntity<TKey>, new()
        where TKey : struct
        where TFilterEntity : IFilterEntity<TKey>

    {

        private DbContext _context;


        protected abstract IQueryable<TDbSet> ApplyFilters(IQueryable<TDbSet> query, TFilterEntity filter);

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Delete(TEntity entity)
        {
            var data = entity.CopyTo<TDbSet>();

            _context.Entry(data).State = EntityState.Deleted;

            _context.SaveChanges();
        }



        public TEntity GetById(TKey key)
        {

            var dataEntity = _context.Set<TDbSet>().Find(key);

            TEntity entity = dataEntity.CopyTo<TEntity>();

            return entity;
        }

        public void Insert(TEntity entity)
        {
            var data = entity.CopyTo<TDbSet>();

            _context.Set<TDbSet>().Add(data);

            _context.SaveChanges();
        }

        public IList<TEntity> Query(TFilterEntity filter)
        {
            var query = _context.Set<TDbSet>().AsQueryable();

            query = ApplyFilters(query, filter);

            List<TEntity> list = new List<TEntity>();

            foreach (var item in query)
            {
                TEntity entity = item.CopyTo<TEntity>();

                list.Add(entity);
            }

            return list;

        }


        public void Update(TEntity entity)
        {
            var data = entity.CopyTo<TDbSet>();

            _context.Entry(data).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
