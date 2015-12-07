using System;

namespace Specification
{
    public class NotSpecification<T> : CompositionSpecification<T>
    {
        private readonly ISpecification<T> spec;

        public NotSpecification(ISpecification<T> spec)
        {
            this.spec = spec;
        }

        public override bool IsSatisfiedBy(T car)
        {
            return !spec.IsSatisfiedBy(car);
        }
    }
}