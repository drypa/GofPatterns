using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook { Implementor = new Oven()};
            var pie = cook.CreatePie();
            Console.WriteLine(pie.State);

            cook.Implementor = new Stove();
            pie = cook.CreatePie();
            Console.WriteLine(pie.State);

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
