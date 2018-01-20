using System;

namespace NETCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 雖然可以將 .NET Framework Class Library 加入到 .NET Core 專案內
            // 可以，當解開底下程式碼，就會有錯誤產生
            var fooObject = new NETFrameworkClassLibrary.FrameworkClass();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();


            //// 雖然可以將 .NET Framework Class Library 加入到 .NET Core 專案內
            //// 可以，當解開底下程式碼，就會有錯誤產生
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
