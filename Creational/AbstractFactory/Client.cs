using System;

namespace AbstractFactory
{
    public class Client
    {
        private readonly IBreadFactory _factory;

        public Client(IBreadFactory factory)
        {
            _factory = factory;
        }

        public void Cook()
        {
            Console.WriteLine("black bread: "+ _factory.CreateBlackBread());
            Console.WriteLine("white bread: "+ _factory.CreateWhiteBread());
        }
    }
}
