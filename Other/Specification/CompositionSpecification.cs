using System;

namespace Specification
{
    public abstract class CompositionSpecification<T> : ISpecification<T>
    {
        public ISpecification<T> And(ISpecification<T> other)
        {
            return new AddSpecification<T>(this, other);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }

        public ISpecification<T> Not(ISpecification<T> other)
        {
            return new NotSpecification<T>(other);
        }

        public abstract bool IsSatisfiedBy(T car);
    }
}