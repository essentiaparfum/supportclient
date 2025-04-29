using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace supportclient
{
    public static class DnnHttpClientFactory
    {
        public static HttpClient Create(int moduleId, int tabId, string xsrfToken)
        {
            var handler = new HttpClientHandler { UseCookies = true, CookieContainer = new CookieContainer() };
            var client = new HttpClient(handler)
            {
                BaseAddress = new Uri("http://rendfejl1011.northeurope.cloudapp.azure.com:8080/")

            };
            client.DefaultRequestHeaders.Add("ModuleId", moduleId.ToString());
            client.DefaultRequestHeaders.Add("TabId", tabId.ToString());
            client.DefaultRequestHeaders.Add("RequestVerificationToken", xsrfToken);
            return client;
        }
    }
}
