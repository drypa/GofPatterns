using System;

namespace Specification.CarSpecifications
{
    public class MersedesCarSpecification : CompositionSpecification<Car>
    {
        public override bool IsSatisfiedBy(Car car)
        {
            return car.Vendor == "mersedes";
        }
    }
}