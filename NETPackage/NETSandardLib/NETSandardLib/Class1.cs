using System;

namespace NETSandardLib
{
    public class Class1
    {
        public void Show()
        {
            Console.WriteLine("Hello .NET Standard");
            Console.WriteLine("List<string> 使用組件的資訊");
            Console.WriteLine(
                   typeof(System.Collections.Generic.List<string>).AssemblyQualifiedName);
            Console.WriteLine();
            Console.WriteLine("List<string> 使用組件所在路徑");
            Console.WriteLine(
                   typeof(System.Collections.Generic.List<string>).Assembly.Location);
            Console.ReadKey();
        }
    }
}
