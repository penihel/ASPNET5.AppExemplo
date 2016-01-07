namespace AppExemplo.Domain.Core.Service
{
    public interface IInsertable<in TEntity> : IService
    {
        void Insert(TEntity entity);
    }
}
