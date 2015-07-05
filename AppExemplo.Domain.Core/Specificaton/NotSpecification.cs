using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo.Domain.Core.Specificaton
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> specification;

        public NotSpecification(ISpecification<T> spec)
        {
            this.specification = spec;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return !this.specification.IsSatisfiedBy(o);
        }
    }
}
