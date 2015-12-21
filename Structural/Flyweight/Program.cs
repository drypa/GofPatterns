using System;
using System.Drawing;

namespace Flyweight
{
    class Program
    {
        private static void Main(string[] args)
        {
            MapElementFactory factory = new MapElementFactory();
            Map map = new Map();
            int treesCount = 5;
            int houseCount = 8;
            int roadCount = 10;
            for (var i = 0; i < treesCount; ++i)
            {
                map.Add(factory.Create("tree"), new Point(1, i));
            }

            for (var i = 0; i < houseCount; ++i)
            {
                map.Add(factory.Create("house"), new Point(2, i));
            }

            for (var i = 0; i < roadCount; ++i)
            {
                map.Add(factory.Create("road"), new Point(3, i));
            }


            map.Draw();

            Console.ReadLine();
        }
    }
}
