using System;

namespace Specification.CarSpecifications
{
    public class RedCarSpecification : CompositionSpecification<Car> 
    {
        public override bool IsSatisfiedBy(Car car)
        {
            return car.Color == "red";
        }
    }
}