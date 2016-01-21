using System;

namespace Proxy
{
    internal class RemoteServerClient
    {
        readonly RemoteServer server = new RemoteServer();
        public virtual string GetData(int yearsAgo)
        {
            return server.GetData(yearsAgo);
        }
    }
}
