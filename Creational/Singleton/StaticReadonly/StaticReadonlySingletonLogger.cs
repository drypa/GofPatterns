using System;

namespace Singleton.StaticReadonly
{
    public class StaticReadonlySingletonLogger
    {
        private static readonly StaticReadonlySingletonLogger uniqueInstance = new StaticReadonlySingletonLogger();

        private StaticReadonlySingletonLogger()
        {
        }
        //наличие статического конструктора не позволяет создавать класс-объект заранее
        static StaticReadonlySingletonLogger()
        {
        }

        public static StaticReadonlySingletonLogger Instance
        {
            get { return uniqueInstance; }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
