using System;
using System.Collections.Generic;

namespace Proxy
{
    internal class RemoteServerProxy : RemoteServer
    {
        private readonly Dictionary<int, string> cache = new Dictionary<int, string>();
        public override string GetData(int yearsAgo)
        {
            if (cache.ContainsKey(yearsAgo))
            {
                return cache[yearsAgo];
            }
            string result = base.GetData(yearsAgo);
            cache.Add(yearsAgo, result);
            return result;
        }
    }
}