using System;

namespace Builder
{
    internal interface ICarBuilder
    {
        CarBuilder AddBackBumper();
        CarBuilder AddCarcase();
        CarBuilder AddElectric();
        CarBuilder AddEngine();
        CarBuilder AddFrontBumper();
        CarBuilder AddWheel();
        Car Get();
        CarBuilder New();
    }
}