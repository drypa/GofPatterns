using System;

namespace Singleton.Lazy
{
    public class LazySingletonLogger
    {
        private static readonly Lazy<LazySingletonLogger> uniqueInstance = new Lazy<LazySingletonLogger>(() => new LazySingletonLogger());

        private LazySingletonLogger()
        {
        }

        public static LazySingletonLogger Instance
        {
            get { return uniqueInstance.Value; }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
