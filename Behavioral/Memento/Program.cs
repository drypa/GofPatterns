using System;

namespace Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var storage = new Storage();
            storage.AddItemToStorage("first string");
            storage.Show();

            var externalStorage = new ExternalStorage();
            externalStorage.Memento = storage.SaveState();
            storage.AddItemToStorage("second string");
            storage.Show();

            storage.RestoreState(externalStorage.Memento);
            Console.WriteLine("Restored state:");
            storage.Show();

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
