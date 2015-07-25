namespace AppExemplo.Domain.Core.Entity
{
    public abstract class EntityBase<TKey> : IEntity<TKey> where TKey : struct

    {
        public virtual TKey Id { get; set; }
    }
}
