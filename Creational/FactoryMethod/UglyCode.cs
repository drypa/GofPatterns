using System;

namespace FactoryMethod
{
    internal class UglyCode : Code
    {
        public UglyCode(string codeLine)
        {
            Text = codeLine;
        }
    }
}
