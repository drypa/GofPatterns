using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new CarBuilder();
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
            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }
}
