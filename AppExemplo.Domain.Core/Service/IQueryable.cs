using System.Collections.Generic;

namespace AppExemplo.Domain.Core.Service
{
    public interface IQueryable<TEntity, in TFilterEntity, in TKey> : IService
    {
        TEntity GetById(TKey key);



        IList<TEntity> Query(TFilterEntity filter);

    }
}
