using System;

namespace FactoryMethod
{
    internal abstract class Programmer
    {
        public abstract Code GenerateCode(string codeLine);
    }
}
