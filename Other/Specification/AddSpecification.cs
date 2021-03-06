﻿using System;

namespace Specification
{
    public class AddSpecification<T> : CompositionSpecification<T>
    {
        private readonly ISpecification<T> one;
        private readonly ISpecification<T> another;

        public AddSpecification(ISpecification<T> one, ISpecification<T> another)
        {
            this.one = one;
            this.another = another;
        }

        public override bool IsSatisfiedBy(T car)
        {
            return one.IsSatisfiedBy(car) && another.IsSatisfiedBy(car);
        }
    }
}