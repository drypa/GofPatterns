using System;

namespace Visitor
{
    public interface IDrawableShape
    {
        void Draw(IDrawer drawer);
    }
}
