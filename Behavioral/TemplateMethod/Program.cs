using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUpdater updater = new FIleHasher();
            updater.Update("./Data/file.txt");
        }
    }
}
