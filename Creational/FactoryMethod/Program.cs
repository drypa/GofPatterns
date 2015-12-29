using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Programmer p = new CodeMonkey();
            var product = p.GenerateCode("//HACK: ");
            Console.WriteLine(product.ShowCode());
            product = p.GenerateCode("cool code");
            Console.WriteLine(product.ShowCode());
            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
