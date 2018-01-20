using System;
using System.Threading.Tasks;

namespace NETCore20Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("This is a .NET Core 2.0 Console App");
            var foo = new NETStandardLibrary.MultitargetLib();
            var fooResult = await foo.GetDotNetCountAsync("http://www.dotnetfoundation.org/");
            Console.WriteLine(fooResult);
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
