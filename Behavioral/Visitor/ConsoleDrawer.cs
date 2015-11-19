﻿using System;

namespace Visitor
{
    public class ConsoleDrawer : IDrawer
    {

        public void DrawCircle(Circle circle)
        {
            Console.WriteLine("I draw circle on console (x:{0},y:{1},Radius:{2})", circle.X, circle.Y, circle.Radius);
        }

        public void DrawRectrangle(Rectangle rectangle)
        {
            Console.WriteLine("I draw rectangle on console: [x:{0},y:{1},width:{2},height:{3}]", rectangle.X, rectangle.Y, rectangle.Width, rectangle.Heigth);
        }
    }
}