namespace AppExemplo.Domain.Core.Service
{
    public interface IDeletable<in TEntity> : IService
    {
        void Delete(TEntity entity);
    }
}
