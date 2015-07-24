using AppExemplo.Domain.Core.Entity;
using AppExemplo.Domain.Core.Repository;

namespace AppExemplo.Data.Core.Repository
{
    public abstract class EntityFrameworkRepositoryBase<TEntity, TKey>
        : RepositoryBase<TEntity, TKey>, IRepository<TEntity, TKey>
         where TEntity : IEntity<TKey>
    {

    }
}
