using System;

namespace FactoryMethod
{
    internal abstract class Code
    {
        protected string Text { get; set; }

        public string ShowCode()
        {
            return Text;
        }
    }
}
