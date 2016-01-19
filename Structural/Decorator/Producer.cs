using System;

namespace Decorator
{
    internal class Producer : IProducer
    {
        public void Produce(string someStuff)
        {
            Console.WriteLine("Pruduce " + someStuff);
        }
    }
}