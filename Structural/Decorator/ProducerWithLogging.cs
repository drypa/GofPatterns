using System;

namespace Decorator
{
    internal class ProducerWithLogging : IProducer
    {
        private readonly IProducer producer;

        public ProducerWithLogging(IProducer producer)
        {
            this.producer = producer;
        }

        public void Produce(string someStuff)
        {
            Console.WriteLine("Start {0} processing",someStuff);
            producer.Produce(someStuff);
            Console.WriteLine("Processing {0} completed", someStuff);
        }
    }
}