using System;

namespace Builder
{
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