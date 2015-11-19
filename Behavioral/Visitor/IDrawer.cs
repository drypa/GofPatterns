using System;

namespace Visitor
{
    public interface IDrawer
    {
        void DrawCircle(Circle circle);
        void DrawRectrangle(Rectangle rectangle);
    }
}