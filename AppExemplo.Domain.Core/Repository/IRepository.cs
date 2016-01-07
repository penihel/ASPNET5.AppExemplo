using AppExemplo.Domain.Core.Entity;
using AppExemplo.Domain.Core.FilterEntity;
using System.Collections.Generic;
using System.Linq;

namespace AppExemplo.Domain.Core.Repository
{
    public interface IRepository<TEntity, TFilterEntity, TKey> 
        where TKey : struct
        where TEntity : IEntity<TKey>
        where TFilterEntity : IFilterEntity<TKey>
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(TKey key);


        
        IList<TEntity> Query(TFilterEntity filter);
        
    }
}
