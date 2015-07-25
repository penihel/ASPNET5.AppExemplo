namespace AppExemplo.Domain.Core.Specificaton
{
    public interface ISpecification<TData>
    {
        bool IsSatisfiedBy(TData o);
        ISpecification<TData> And(ISpecification<TData> specification);
        ISpecification<TData> Or(ISpecification<TData> specification);
        ISpecification<TData> Not(ISpecification<TData> specification);
    }
}
