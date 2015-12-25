using System;

namespace Strategy
{
    internal class ConsoleLogger : ILoggerStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine("I write your message('{0}') to console", message);
        }
    }
}
