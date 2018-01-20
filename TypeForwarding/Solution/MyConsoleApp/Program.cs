using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAssembly.SayHello.Hello("Vulcan"));
            Console.WriteLine(typeof(MyAssembly.SayHello).AssemblyQualifiedName);
            Console.ReadKey();
        }
    }
}
