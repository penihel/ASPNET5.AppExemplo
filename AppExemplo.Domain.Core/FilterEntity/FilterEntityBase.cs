namespace AppExemplo.Domain.Core.FilterEntity
{
    public abstract class FilterEntityBase<TKey> : IFilterEntity<TKey> where TKey : struct
    {
        public virtual TKey? Id { get; set; }

    }
}
