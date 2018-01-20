using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fooObject = new NETFrameworkClassLibrary.FrameworkClass();
            //var barObject = fooObject.MyProperty;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Press any key for continuing...");
            //Console.ReadKey();

            var content = NETStandardClassLibrary.StandardClass.GetContent().Result;
            Console.WriteLine($"Web Content Length : {content.Length}");
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
