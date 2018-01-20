using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFramework461Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a .NET Framework 4.6.1 Console App");
            Console.WriteLine(new NETStandardLibrary.MultitargetLib().GetDotNetCount("http://www.dotnetfoundation.org/"));
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
