using System;
using System.Collections.Generic;

namespace Specification
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car { Color = "blue", Price = 99999, Vendor = "vaz" },
                new Car { Color = "red", Price = 99999, Vendor = "vaz" },
                new Car { Color = "red", Price = 50000, Vendor = "vaz" },
                new Car { Color = "green", Price = 99999, Vendor = "vaz" },
                new Car { Color = "orange", Price = 99999, Vendor = "vaz" },
                new Car { Color = "blue", Price = 109999, Vendor = "vaz" },
                new Car { Color = "red", Price = 109999, Vendor = "vaz" },
                new Car { Color = "green", Price = 109999, Vendor = "vaz" },
                new Car { Color = "green", Price = 2999000, Vendor = "mersedes" },
                new Car { Color = "red", Price = 2999000, Vendor = "mersedes" },
                new Car { Color = "red", Price = 1000000, Vendor = "mersedes" },
                new Car { Color = "blue", Price = 2999000, Vendor = "mersedes" },
                new Car { Color = "white", Price = 2999000, Vendor = "mersedes" }
            };
            ISpecification<Car> redCheapCarSpec = Cars.Red.And(Cars.Cheap);
            Console.WriteLine("cheap red cars is:");
            foreach (Car car in cars)
            {
                if (redCheapCarSpec.IsSatisfiedBy(car))
                {
                    Console.WriteLine(car.ToString());
                }
            }

            ISpecification<Car> redCheapMersedesSpec = Cars.Red.And(Cars.Cheap).And(Cars.Mersedes);
            Console.WriteLine("cheap red mersedes is:");
            foreach (Car car in cars)
            {
                if (redCheapMersedesSpec.IsSatisfiedBy(car))
                {
                    Console.WriteLine(car.ToString());
                }
            }
            ISpecification<Car> redCheapNotMersedesSpec = Cars.Red.And(Cars.Cheap).Not(Cars.Mersedes);
            Console.WriteLine("cheap red non mersedes is:");
            foreach (Car car in cars)
            {
                if (redCheapNotMersedesSpec.IsSatisfiedBy(car))
                {
                    Console.WriteLine(car.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
