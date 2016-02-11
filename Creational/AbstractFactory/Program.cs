using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IBreadFactory factory1 = new FazerFactory();

            new Client(factory1).Cook();

            IBreadFactory factory2 = new BalticBreadFactory();
            new Client(factory2).Cook();

            Console.ReadLine();
        }
    }
}
