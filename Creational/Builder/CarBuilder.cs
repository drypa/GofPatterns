using System;

namespace Builder
{
    internal class CarBuilder : ICarBuilder
    {
        private Car car;

        private Car Car
        {
            get { return car ?? (car = new Car()); }
        }

        public CarBuilder AddBackBumper()
        {
            Car.BackBumper = true;
            return this;
        }

        public CarBuilder AddCarcase()
        {
            Car.Carcase = true;
            return this;
        }

        public CarBuilder AddElectric()
        {
            Car.Electric = true;
            return this;
        }

        public CarBuilder AddEngine()
        {
            Car.EngineExists = true;
            return this;
        }

        public CarBuilder AddFrontBumper()
        {
            Car.FrontBumper = true;
            return this;
        }

        public CarBuilder AddWheel()
        {
            Car.WheelsCount += 1;
            return this;
        }

        public Car Get()
        {
            return Car;
        }

        public CarBuilder New()
        {
            car = new Car();
            return this;
        }
    }
}