using System;

namespace Strategy
{
    internal class Client
    {
        public ILoggerStrategy Logger { get; set; }

        public void DoSomeStuff(string info)
        {
            Logger.Log(info);
        }
    }
}
