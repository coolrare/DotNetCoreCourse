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
            Console.WriteLine("Hello .NET Framework");
            Console.WriteLine("List<string> 使用組件的資訊");
            Console.WriteLine(typeof(System.Collections.Generic.List<string>).AssemblyQualifiedName);
            Console.WriteLine();
            Console.WriteLine("List<string> 使用組件所在路徑");
            Console.WriteLine(typeof(System.Collections.Generic.List<string>).Assembly.Location);
            Console.ReadKey();
        }
    }
}
