using System;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion.Client;
using MagicOnionSample.ServiceDefinition;

namespace MagicOnionSample.Client
{
    internal class Program
    {
        private static void Main()
        {
            MainAsync().Wait();
        }

        private static async Task MainAsync()
        {
            var channel = new Channel("localhost", 12345, ChannelCredentials.Insecure);
            var client = MagicOnionClient.Create<ISampleApi>(channel);
            var result = await client.Sum(100, 200);

            Console.WriteLine($"Result : {result}");
            Console.ReadLine();
        }
    }
}
