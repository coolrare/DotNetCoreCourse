using System;

namespace NETCore11App
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
