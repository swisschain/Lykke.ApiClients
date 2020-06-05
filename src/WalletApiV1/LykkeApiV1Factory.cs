using System;
using System.Net.Http;

namespace Lykke.ApiClients.V1
{
    public static class LykkeApiV1Factory
    {
        public const string Host = "https://api.lykke.com/";

        public static ILykkeWalletAPIv1Client Create()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Host);

            return new LykkeWalletAPIv1Client(client);
        }

        public static ILykkeWalletAPIv1Client Create(string host)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(host);

            return new LykkeWalletAPIv1Client(client);
        }
    }
}
