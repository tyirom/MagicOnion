using System;
using Grpc.Core;
using MagicOnion.Server;

namespace MagicOnionSample.Service
{
    internal class Program
    {
        private static void Main()
        {
            var service = MagicOnionEngine.BuildServerServiceDefinition();
            var port = new ServerPort("localhost", 12345, ServerCredentials.Insecure);
            var server = new Server {Services = {service}, Ports = {port}};
            server.Start();

            Console.ReadLine();
        }
    }
}
