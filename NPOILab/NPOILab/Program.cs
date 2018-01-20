using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.IO;

namespace NPOILab
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateExcelFile();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }

        private static void CreateExcelFile()
        {
            IWorkbook wb = new HSSFWorkbook();
            ISheet ws = wb.CreateSheet("我的課程");
            ws.CreateRow(0);
            ws.GetRow(0).CreateCell(0).SetCellValue("名稱");
            ws.GetRow(0).CreateCell(1).SetCellValue("時數");
            ws.CreateRow(1);
            ws.GetRow(1).CreateCell(0).SetCellValue(".NET Core 2.0");
            ws.GetRow(1).CreateCell(1).SetCellValue(14);
            ws.CreateRow(2);
            ws.GetRow(2).CreateCell(0).SetCellValue("C# 7.0");
            ws.GetRow(2).CreateCell(1).SetCellValue(7);
            ws.CreateRow(3);
            ws.GetRow(3).CreateCell(0).SetCellValue("Xamarin.Forms");
            ws.GetRow(3).CreateCell(1).SetCellValue(35);
            ws.CreateRow(4);
            ws.GetRow(4).CreateCell(0).SetCellValue("ASP.NET Core");
            ws.GetRow(4).CreateCell(1).SetCellValue(35);
            FileStream file = new FileStream("MyCourse.xls", FileMode.Create);
            wb.Write(file);
            file.Close();
        }
    }
}
