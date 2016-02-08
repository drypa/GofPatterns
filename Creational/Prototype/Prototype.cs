using System;

namespace Prototype
{
    internal abstract class Prototype
    {
        protected Prototype()
        {
            Console.WriteLine("\tPrototype ctor");
        }

        public string Content { get; set; }
        public abstract Prototype Clone();
    }
}