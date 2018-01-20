using System;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello .NET Core");
            MyLibrary.MyClass foo = new MyLibrary.MyClass();
            Console.WriteLine($"2 + 3 = {foo.Sum(2,3)}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
