using System;

namespace Visitor
{
    public class Rectangle : IDrawableShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Heigth { get; set; }

        public void Draw(IDrawer drawer)
        {
            drawer.DrawRectrangle(this);
        }
    }
}