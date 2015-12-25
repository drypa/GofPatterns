using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Client client = new Client { Logger = new ConsoleLogger()};
            client.DoSomeStuff("need more work!");
            client.Logger = new DbLogger();
            client.DoSomeStuff("work hard");

            Console.ReadLine();
        }
    }
}
