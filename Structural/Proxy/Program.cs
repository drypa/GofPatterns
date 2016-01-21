using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Client client = new Client(new RemoteServerProxy());
            client.GetDataFromRemoteServer(0);
            client.GetDataFromRemoteServer(1);
            client.GetDataFromRemoteServer(2);
            client.GetDataFromRemoteServer(3);
            client.GetDataFromRemoteServer(4);

            client.GetDataFromRemoteServer(0);
            client.GetDataFromRemoteServer(1);
            client.GetDataFromRemoteServer(2);
            client.GetDataFromRemoteServer(3);
            client.GetDataFromRemoteServer(4);
            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
