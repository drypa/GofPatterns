using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IHandler chain = new EmptyHandler(new MiddleLenghtHandler(new VeryLargeHandler()));
            string message = null;
            chain.Handle(ref message);
            Console.WriteLine(message);

            message = new string('a',100);
            chain.Handle(ref message);
            Console.WriteLine(message);


            message = new string('a', 1000);
            chain.Handle(ref message);
            Console.WriteLine(message);

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }

    }
}
