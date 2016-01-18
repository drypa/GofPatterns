using System;

namespace Adapter
{
    internal class ToRussianPlugAdapter : RussianPlug
    {
        private readonly EuroPlug euroPlug;

        public ToRussianPlugAdapter(EuroPlug euroPlug)
        {
            this.euroPlug = euroPlug;
        }

        public override void Connect()
        {
            Console.WriteLine("+: " + euroPlug.PlusContact);
            Console.WriteLine("-: " + euroPlug.MinusContact);
            Console.WriteLine("V: " + 220);
        }

    }
}
