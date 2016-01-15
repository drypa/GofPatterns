using System;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var human = new Human();
            human.Salute();

            human.GetIll();
            human.Salute();

            human.GetWell();
            human.Salute();

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
