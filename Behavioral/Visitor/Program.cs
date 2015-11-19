using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleDrawer = new ConsoleDrawer();
            var printerDrawer = new PrinterDrawer();
            new Circle{ Radius = 1, X = 1, Y = 1 }.Draw(consoleDrawer);
            new Circle { Radius = 2, X = 2, Y = 2 }.Draw(printerDrawer);

            new Rectangle{X = 1,Y = 1,Heigth = 1,Width = 1}.Draw(consoleDrawer);
            new Rectangle { X = 2, Y = 2, Heigth = 2, Width = 2 }.Draw(printerDrawer);

            Console.ReadLine();
        }
    }
}
