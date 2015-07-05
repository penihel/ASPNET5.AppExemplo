namespace AppExemplo.Domain.Core.Entity
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public abstract TKey Id { get; set; }
    }
}
