using System;
using Specification.CarSpecifications;

namespace Specification
{
    internal static class Cars
    {
        public static ISpecification<Car> Cheap { get; } = new CheapCarSpecification();
        public static ISpecification<Car> Mersedes { get; } = new MersedesCarSpecification();
        public static ISpecification<Car> Red { get; } = new RedCarSpecification();
    }
}
