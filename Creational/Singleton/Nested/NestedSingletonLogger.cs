using System;

namespace Singleton.Nested
{
    public class NestedSingletonLogger
    {
        private NestedSingletonLogger()
        {
        }

        public static NestedSingletonLogger Instance
        {
            get { return Holder.UniqueInstance; }
        }

        private static class Holder
        {
            public static readonly NestedSingletonLogger UniqueInstance = new NestedSingletonLogger();
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
