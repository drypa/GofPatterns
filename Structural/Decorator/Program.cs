using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IProducer producer = new ProducerWithLogging(new Producer());
            producer.Produce("work hard");

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
