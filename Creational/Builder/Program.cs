using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarsMill mill = new CarsMill();
            Car car = mill.CreateCar();
            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }

    internal class CarsMill
    {
        readonly ICarBuilder builder = new CarBuilder();
        public Car CreateCar()
        {
            Car car = builder.AddWheel()
               .AddElectric()
               .AddEngine()
               .AddWheel()
               .AddWheel()
               .AddWheel()
               .AddFrontBumper()
               .AddCarcase()
               .AddBackBumper()
               .Get();
            return car;
        }
    }
}
