using System;
using System.Collections.Generic;
using System.Drawing;

namespace Flyweight
{
    public class Map
    {
        private readonly Dictionary<Point, MapElement> elements = new Dictionary<Point, MapElement>();

        public void Add(MapElement element, Point point)
        {
            elements.Add(point, element);
        }

        public void Draw()
        {
            foreach (var pair in elements)
            {
                pair.Value.Draw(pair.Key);
            }
        }
    }
}
