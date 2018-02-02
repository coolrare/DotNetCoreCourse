using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01NETFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" .NET Framework 4.6.1 ");
            Console.WriteLine("======================");

            ShowDateTimeInfo();
        }

        private static void ShowDateTimeInfo()
        {
            Console.WriteLine();
            Console.WriteLine("DateTime 型別的完整組件名稱");
            Console.WriteLine(typeof(DateTime).AssemblyQualifiedName);
            Console.WriteLine();
            Console.WriteLine("DateTime 型別的組件所在路徑");
            Console.WriteLine(typeof(DateTime).Assembly.Location);
            Console.WriteLine();
            Console.WriteLine("DateTime.Now.ToString() 執行結果");
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine();
        }
    }
}
