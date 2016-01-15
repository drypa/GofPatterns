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
}
