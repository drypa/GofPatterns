using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var plug = new EuroPlug
            {
                GroundContact = -1,
                MinusContact = -1,
                PlusContact = 1,
                Voltage = 230
            };
            RussianPlug russianPlug = new ToRussianPlugAdapter(plug);
            russianPlug.Connect();

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
