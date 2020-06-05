using System;
using System.Net.Http;

namespace Lykke.ApiClients.V2
{
    public class LykkeApiV2Factory
    {
        public const string Host = "https://apiv2.lykke.com/";

        public static ILykkeWalletAPIv2Client Create()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Host);

            return new LykkeWalletAPIv2Client(client);
        }

        public static ILykkeWalletAPIv2Client Create(string host)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(host);

            return new LykkeWalletAPIv2Client(client);
        }
    }
}
