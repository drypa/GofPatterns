using System;

namespace Specification
{
    public interface ISpecification<T>
    {
        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not(ISpecification<T> other);
        bool IsSatisfiedBy(T car);
    }
}
