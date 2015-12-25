using System;

namespace Strategy
{
    internal class DbLogger : ILoggerStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine("Trust me, I write your message('{0}') to database, isn't it", message);
        }
    }
}
