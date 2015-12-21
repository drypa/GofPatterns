using System;
using System.Drawing;

namespace Flyweight
{
    public class MapElement
    {
        private readonly int uniqueId;

        /// <summary>
        /// 
        /// </summary>
        private Guid Id;
        public MapElement(string type, int uniqueId)
        {
            this.uniqueId = uniqueId;
            Type = type;
        }

        public string Type { get; set; }
        //Large object
        public byte[] Bitmap { get; set; }

        public void Draw(Point point)
        {
            Console.WriteLine("Item {0} drawed on [{1},{2}] id:{3}", Type, point.X, point.Y, uniqueId);
        }
    }
}