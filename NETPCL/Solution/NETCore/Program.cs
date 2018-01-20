using System;

namespace NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PCLLibrary.SayHello.Hello(".NET Core"));
            Console.ReadKey();
        }
    }
}
