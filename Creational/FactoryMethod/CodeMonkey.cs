using System;

namespace FactoryMethod
{
    internal class CodeMonkey : Programmer
    {
        public override Code GenerateCode(string codeLine)
        {
            if (codeLine.Contains("HACK"))
            {
                return new UglyCode("//HACK:");
            }
            return new GoodCode("private static void Main(string[] args)");
            
        }
    }
}
