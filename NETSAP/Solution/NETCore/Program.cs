using System;

namespace NETCore
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
