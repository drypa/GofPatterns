using System;

namespace Adapter
{
    internal class RussianPlug
    {
        public int MinusContact { get; set; }
        public int PlusContact { get; set; }
        public int Voltage { get; set; }

        public virtual void Connect()
        {
            Console.WriteLine("+: " + PlusContact);
            Console.WriteLine("-: " + MinusContact);
            Console.WriteLine("V: " + Voltage);
        }
    }
}