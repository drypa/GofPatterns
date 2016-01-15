using System;

namespace State
{
    internal class HealthyState : IHumanState
    {
        public void SayHello()
        {
            Console.WriteLine("Hello. I'm fine");
        }
    }
}