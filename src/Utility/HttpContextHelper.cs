using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Destiny_2_Interface.Utility
{
    internal static class HttpContextHelper
    {
        private static readonly string ApiKeyHeaderTitle = "X-API-Key";
        
        internal static string GetContent(string apiKey, string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(ApiKeyHeaderTitle, apiKey);
                HttpResponseMessage response = client.GetAsync(url).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
