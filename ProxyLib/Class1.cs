using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProxyTest
{
    public static class Class1
    {
        private static async Task Api(string url)
        {
            var handler = new HttpClientHandler()
            {
                DefaultProxyCredentials = CredentialCache.DefaultCredentials
            };
            var client = new HttpClient(handler);
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
        }

        public static async Task Http()
        {
            await Api("http://www.mocky.io/v2/5185415ba171ea3a00704eed");
        }

        public static async Task Https()
        {
            await Api("https://www.mocky.io/v2/5185415ba171ea3a00704eed");
        }
    }
}
