using System;

namespace Specification.CarSpecifications
{
    public class CheapCarSpecification : CompositionSpecification<Car>
    {
        public override bool IsSatisfiedBy(Car car)
        {
            return car.Price < 100000;
        }
    }
}