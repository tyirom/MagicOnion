using System;
using System.Threading.Tasks;
using MagicOnion;
using MagicOnion.Server;
using MagicOnionSample.ServiceDefinition;

namespace MagicOnionSample.Service
{
    public class SampleApi : ServiceBase<ISampleApi>, ISampleApi
    {
        public async UnaryResult<int> Sum(int x, int y)
        {
            Console.WriteLine($"(x, y) = ({x}, {y})");
            await Task.Delay(10);
            return x + y;
        }
    }
}