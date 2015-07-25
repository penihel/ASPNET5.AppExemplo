namespace AppExemplo.Domain.Core.FilterEntity
{
    public interface IFilterEntity<TKey> where TKey: struct
    {
        TKey? Id { get; set; }
    }
}
