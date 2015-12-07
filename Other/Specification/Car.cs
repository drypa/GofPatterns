using System;

namespace Specification
{
    public class Car
    {
        public string Color { get; set; }
        public double Price { get; set; }
        public string Vendor { get; set; }
        public override string ToString()
        {
            return string.Format("Vendor:{0}, Color:{1},Price{2}",Vendor,Color,Price.ToString());
        }
    }
}