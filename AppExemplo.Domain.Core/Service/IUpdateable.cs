namespace AppExemplo.Domain.Core.Service
{
    public interface IUpdateable<in TEntity> : IService
    {
        void Update(TEntity entity);
    }
}
