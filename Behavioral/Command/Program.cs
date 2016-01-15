using System;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manipulator manipulator = new Manipulator();
            Console.WriteLine(manipulator.GetState());

            RemoteController controller = new RemoteController(manipulator);
            controller.Up(10);
            Console.WriteLine(manipulator.GetState());

            controller.Left(20);
            Console.WriteLine(manipulator.GetState());

            controller.Right(10);
            Console.WriteLine(manipulator.GetState());


            controller.Down(30);
            Console.WriteLine(manipulator.GetState());


            controller.UndoLastCommand();
            Console.WriteLine(manipulator.GetState());

            controller.UndoLastCommand();
            Console.WriteLine(manipulator.GetState());

            controller.UndoLastCommand();
            Console.WriteLine(manipulator.GetState());

            controller.UndoLastCommand();
            Console.WriteLine(manipulator.GetState());

            Console.ReadLine();
        }
    }
}
