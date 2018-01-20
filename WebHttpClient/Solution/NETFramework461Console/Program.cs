using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFramework461Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("This is a .NET Framework 4.6.1 Console App");
            var foo = new NETStandardLibrary.MultitargetLib();
            var fooResult = await foo.GetDotNetCountAsync("http://www.dotnetfoundation.org/");
            Console.WriteLine(fooResult);
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
