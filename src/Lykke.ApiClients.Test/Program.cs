using System;
using System.Threading.Tasks;
using Lykke.ApiClients.V1;
using Lykke.ApiClients.V2;
using Newtonsoft.Json;

namespace Lykke.ApiClients.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var clientv1 = LykkeApiV1Factory.Create();
            var asset = await clientv1.GetAssetsByIdAsync("BTC");
            Console.WriteLine(JsonConvert.SerializeObject(asset));

            var clientv2 = LykkeApiV2Factory.Create();
            var res = await clientv2.GetAllAsync();
            Console.WriteLine(JsonConvert.SerializeObject(res));

            Console.WriteLine("Hello World!");
        }
    }
}
