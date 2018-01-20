using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{MyLibrary.SayHello.Hello()}");
            Console.ReadKey();
        }
    }
}
