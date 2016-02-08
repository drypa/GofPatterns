using System;
using System.Runtime.Remoting.Messaging;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Prototype prototype = new PrototypeImpl();
            prototype.Content = "some content";
            Prototype copy = prototype.Clone();
            Console.WriteLine(copy.Content);

            prototype.Content = "changed content";
            Console.WriteLine(copy.Content);
            Prototype copy1 = prototype.Clone();
            Console.WriteLine(copy1.Content);

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
