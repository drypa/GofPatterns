using System;
using System.Threading;

namespace Proxy
{
    internal class RemoteServer
    {
        public string GetData(int yearsAgo)
        {
            Thread.Sleep(2000);
            return DateTime.Now.AddYears(-yearsAgo).ToString("dd.MM.yyyy");
        }
    }
}