using System;

namespace Visitor
{
    public class Circle : IDrawableShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public void Draw(IDrawer drawer)
        {
            drawer.DrawCircle(this);
        }
    }
}