using System;

namespace _03NETStandard20
{
    public class DateTimeUtil
    {
        public static void ShowDateTimeInfo()
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
