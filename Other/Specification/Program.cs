using System;
using System.Collections.Generic;
using Specification.CarSpecifications;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car{Color = "blue",Price = 99999,Vendor = "vaz"},
                new Car{Color = "red",Price = 99999,Vendor = "vaz"},
                new Car{Color = "red",Price = 50000,Vendor = "vaz"},
                new Car{Color = "green",Price = 99999,Vendor = "vaz"},
                new Car{Color = "orange",Price = 99999,Vendor = "vaz"},
                new Car{Color = "blue",Price = 109999,Vendor = "vaz"},
                new Car{Color = "red",Price = 109999,Vendor = "vaz"},
                new Car{Color = "green",Price = 109999,Vendor = "vaz"},
                new Car{Color = "green",Price = 2999000,Vendor = "mersedes"},
                new Car{Color = "red",Price = 2999000,Vendor = "mersedes"},
                new Car{Color = "red",Price = 1000000,Vendor = "mersedes"},
                new Car{Color = "blue",Price = 2999000,Vendor = "mersedes"},
                new Car{Color = "white",Price = 2999000,Vendor = "mersedes"},
            };
            ISpecification<Car> redCheapCarSpec = new RedCarSpecification().And(new CheapCarSpecification());
            foreach (Car car in cars)
            {
                if (redCheapCarSpec.IsSatisfiedBy(car))
                {
                    Console.WriteLine(car.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
