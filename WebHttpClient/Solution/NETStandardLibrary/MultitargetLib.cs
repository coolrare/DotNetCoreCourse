using System;
using System.Text.RegularExpressions;
#if NET40
// This only compiles for the .NET Framework 4 targets
using System.Net;
#else
// This compiles for all other targets
using System.Net.Http;
using System.Threading.Tasks;
#endif

namespace NETStandardLibrary
{
    public class MultitargetLib
    {
#if NET40
        private readonly WebClient _client = new WebClient();
        private readonly object _locker = new object();
#else
        private readonly HttpClient _client = new HttpClient();
#endif

#if NET40
        // .NET Framework 4.0 並沒有支援 async/await 用法
        public string GetDotNetCount(string url)
        {
            var uri = new Uri(url);

            string result = "";

            // 避免多執行緒同時呼叫這個方法，因此，要修正這個方法具有執行緒安全的特性 
            lock (_locker)
            {
                result = _client.DownloadString(uri);
            }

            int dotNetCount = Regex.Matches(result, ".NET").Count;

            Console.WriteLine("這裡執行的方法是 GetDotNetCount");
            return $"在這裡提到 .NET 共有 {dotNetCount} 次!";
        }
#else
        // .NET 4.5+ 就有支援非同步程式設計 async/await!
        public async Task<string> GetDotNetCountAsync(string url)
        {
            // HttpClient 是執行緒安全的，因此，不需要特別做 lock
            var result = await _client.GetStringAsync(url);

            int dotNetCount = Regex.Matches(result, ".NET").Count;

            Console.WriteLine("這裡執行的方法是 GetDotNetCountAsync");
            return $"在這裡提到 .NET 共有 {dotNetCount} 次!";
        }
#endif
    }
}
