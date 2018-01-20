using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFramework461App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{new NETStandardLib.SayHello().Hello()}");
            Console.WriteLine($"Press any key to Exist...{Environment.NewLine}");
            Console.ReadKey();
        }
    }
}
