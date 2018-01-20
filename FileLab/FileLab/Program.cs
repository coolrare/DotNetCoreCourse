using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FileLab
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputFileSystemInfo();
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

            WorkWithFiles();
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

        }


        public static void OutputFileSystemInfo()
        {
            Console.WriteLine($"OS:                        {RuntimeInformation.OSDescription}");
            Console.WriteLine($"Framework:                 {RuntimeInformation.FrameworkDescription}");
            Console.WriteLine($"OS Architecture            {RuntimeInformation.OSArchitecture}");
            Console.WriteLine($"Process Architecture       {RuntimeInformation.ProcessArchitecture}");
            Console.WriteLine("");
            Console.WriteLine($"Path.PathSeparator:              {Path.PathSeparator}");
            Console.WriteLine($"Path.DirectorySeparatorChar:     {Path.DirectorySeparatorChar}");
            Console.WriteLine($"Directory.GetCurrentDirectory(): {Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Environment.CurrentDirectory:    {Environment.CurrentDirectory}");
            Console.WriteLine($"Environment.SystemDirectory:     {Environment.SystemDirectory}");
            Console.WriteLine($"Path.GetTempPath():              {Path.GetTempPath()}");
            Console.WriteLine($"GetFolderPath(SpecialFolder):");
            Console.WriteLine($"  System:                        {Environment.GetFolderPath(Environment.SpecialFolder.System)}");
            Console.WriteLine($"  ApplicationData:               {Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}");
            Console.WriteLine($"  MyDocuments:                   {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
            Console.WriteLine($"  Personal:                      {Environment.GetFolderPath(Environment.SpecialFolder.Personal)}");
        }

        public static void WorkWithFiles()
        {
            // define a custom directory path 
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var customFolder = new string[]
                { userFolder, "MiniASP", "NETCore", "OutputFiles" };

            string dir = Path.Combine(customFolder);
            Directory.CreateDirectory(dir);

            // define file paths
            string textFile = Path.Combine(dir, "Dummy.txt");
            string backupFile = Path.Combine(dir, "Dummy.bak");

            Console.WriteLine($"Working with: {textFile}");

            // check if a file exists 
            Console.WriteLine($"Does it exist? {File.Exists(textFile)}  ");
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

            // create a new text file and write a line to it 
            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("Hello, C#!");
            textWriter.Close(); // close file and release resources

            Console.WriteLine($"Does it exist? {File.Exists(textFile)}  ");
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

            // copy a file and overwrite if it already exists 
            File.Copy(
                sourceFileName: textFile,
                destFileName: backupFile,
                overwrite: true);

            Console.WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

            Console.WriteLine("Confirm the files exist, and then press ENTER: ");
            Console.ReadLine();

            // delete a file 
            File.Delete(textFile);

            Console.WriteLine($"Does {textFile}  exist? {File.Exists(textFile)}");
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

            // read from a text file 
            Console.WriteLine($"Reading contents of {backupFile}:");
            StreamReader textReader = File.OpenText(backupFile);
            Console.WriteLine(textReader.ReadToEnd());
            textReader.Close();

            Console.WriteLine($"File Name: {Path.GetFileName(textFile)}");
            Console.WriteLine($"File Name without Extension: {Path.GetFileNameWithoutExtension(textFile)}");
            Console.WriteLine($"File Extension: {Path.GetExtension(textFile)}");
            Console.WriteLine($"Random File Name: {Path.GetRandomFileName()}");
            Console.WriteLine($"Temporary File Name: {Path.GetTempFileName()}");

            var info = new FileInfo(backupFile);
            Console.WriteLine($"{backupFile}:");
            Console.WriteLine($"  Contains {info.Length} bytes");
            Console.WriteLine($"  Last accessed {info.LastAccessTime}");
            Console.WriteLine($"  Has readonly set to {info.IsReadOnly}");

            Console.WriteLine($"Compressed? {info.Attributes.HasFlag(FileAttributes.Compressed)}");

        }


    }
}
