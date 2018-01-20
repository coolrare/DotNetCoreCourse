using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETFramework4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a .NET Framework 4.0 Console App");
            var foo = new NETStandardLibrary.MultitargetLib();
            var fooResult = foo.GetDotNetCount("http://www.dotnetfoundation.org/");
            Console.WriteLine(fooResult);
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
