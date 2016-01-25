using System;

namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            INode<string> n4 = NodesFactory<string>.Create("!");
            INode<string> n3 = NodesFactory<string>.Create("world");
            INode<string> n2 = NodesFactory<string>.Create(" ");
            INode<string> n1 = NodesFactory<string>.Create("Hello");

            n1.Process(OnAction);
            Console.WriteLine();

            INode<string> expression = NodesFactory<string>.Create("Yes! ", n1, n2, n3, n4);
            expression.Process(OnAction);
            Console.WriteLine();

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }

        private static void OnAction(string x)
        {
            Console.Write(x);
        }
    }
}
