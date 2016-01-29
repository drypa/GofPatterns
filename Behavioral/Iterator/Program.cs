using System;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IIterable list = new SuperList();
            IIterator<int> iterator = list.GetIterator();
            Console.WriteLine("SuperList iteration");
            Console.WriteLine(iterator.Current);
            const int maxIteration = 10;
            int counter = 0;
            while (!iterator.IsDone && counter < maxIteration)
            {
                ++counter;
                iterator.Next();
                Console.WriteLine(iterator.Current);
            }


            list = new OrdinaryList(10);
            var anotherIterator = list.GetIterator();
            Console.WriteLine("OrdinaryList iteration");
            Console.WriteLine(anotherIterator.Current);
            while (!anotherIterator.IsDone)
            {
                anotherIterator.Next();
                Console.WriteLine(anotherIterator.Current);
            }


            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}