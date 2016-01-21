using System;

namespace Proxy
{
    internal class Client
    {
        private readonly RemoteServer remoteServer;

        public Client(RemoteServer remoteServer)
        {
            this.remoteServer = remoteServer;
        }

        public void GetDataFromRemoteServer(int yearsAgo)
        {
            Console.WriteLine(remoteServer.GetData(yearsAgo));
        }
    }
}