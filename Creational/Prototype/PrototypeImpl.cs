using System;

namespace Prototype
{
    internal class PrototypeImpl : Prototype
    {
        public PrototypeImpl()
        {
            Console.WriteLine("\tPrototypeImpl ctor");
        }
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}