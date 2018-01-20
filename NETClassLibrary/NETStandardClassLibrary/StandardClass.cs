using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETStandardClassLibrary
{
    public static class StandardClass
    {
        public static async Task<string> GetContent()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("http://www.microsoft.com");
            return result;
        }
    }
}
