using System;

namespace NETCore20Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a .NET Core 2.0 Console App");
            Console.WriteLine(new NETStandardLibrary.MultitargetLib().GetDotNetCount("http://www.dotnetfoundation.org/"));
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
