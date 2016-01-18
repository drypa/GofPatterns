using System;

namespace Adapter
{
    internal class EuroPlug
    {
        public int GroundContact { get; set; }
        public int MinusContact { get; set; }
        public int PlusContact { get; set; }
        public int Voltage { get; set; }
    }
}