using System;

namespace Specification.CarSpecifications
{
    public class ExpensiceCarSpecification : CompositionSpecification<Car>
    {
        public override bool IsSatisfiedBy(Car car)
        {
            return car.Price > 1000000;
        }
    }
}