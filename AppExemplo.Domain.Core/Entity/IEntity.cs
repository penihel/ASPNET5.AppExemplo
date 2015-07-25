namespace AppExemplo.Domain.Core.Entity
{
    public interface IEntity<TKey> 
        where TKey : struct
    {
        TKey Id { get; set; }
    }
}
