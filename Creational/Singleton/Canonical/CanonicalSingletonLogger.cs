using System;

namespace Singleton.Canonical
{
    public class CanonicalSingletonLogger
    {
        private static readonly Object lockObj = new object();
        private static volatile CanonicalSingletonLogger uniqueInstance;

        private CanonicalSingletonLogger()
        {
        }

        public static CanonicalSingletonLogger Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    lock (lockObj)
                    {
                        if (uniqueInstance == null)
                        {
                            uniqueInstance = new CanonicalSingletonLogger();
                        }
                    }
                }
                return uniqueInstance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
