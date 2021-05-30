using System;
using System.IO;
using System.Linq;

namespace DirectoriesWithLinQApp
{
    class Program
    {
        static string folderpath = "C:/Windows/System32";
        static void Main(string[] args)
        {
            DisplayBigFile();
            //DisplayBigFileName();
            //DisplayFolderWithA();
        }

        private static void DisplayBigFile()
        {
            var todayFiles = Directory.GetFiles(folderpath)
                                      .OrderByDescending(f => new FileInfo(f).Length)
                                      .Take(10);
            foreach (string str in todayFiles)
            {
                //Console.WriteLine(str.Length);
                //Console.WriteLine(str);
                Console.WriteLine(new FileInfo(str).Length);
                Console.WriteLine(new FileInfo(str).Name);
            }
        }
        private static void DisplayBigFileName()
        {
            var todayFiles = Directory.GetFiles(folderpath)
                                        .OrderByDescending(f => new FileInfo(f).Name.Length)
                                        .Take(10);
            foreach (string str in todayFiles)
            {
                Console.WriteLine(new FileInfo(str).Name);
            }
        }
        private static void DisplayFolderWithA()
        {
            var todayFiles = Directory.GetDirectories(folderpath)
                                      .Where(f=> new FileInfo(f).Name.Contains("a"))
                                      .ToList();
            
            foreach (string str in todayFiles)
            {
                
                Console.WriteLine(new FileInfo(str).Name);
            }
        }
    }
}
