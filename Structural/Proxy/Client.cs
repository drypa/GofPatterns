using System;

namespace Proxy
{
    internal class Client
    {
        private readonly RemoteServerClient remoteServerClient;

        public Client(RemoteServerClient remoteServerClient)
        {
            this.remoteServerClient = remoteServerClient;
        }

        public void GetDataFromRemoteServer(int yearsAgo)
        {
            Console.WriteLine(remoteServerClient.GetData(yearsAgo));
        }
    }
}