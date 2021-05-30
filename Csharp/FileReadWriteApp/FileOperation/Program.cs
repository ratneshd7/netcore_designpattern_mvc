using System;
using System.IO;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ratnesh", "Onkar","Hiren" };

            using (StreamWriter sw = new StreamWriter("~ReadWriteFile.txt"))// ~ is used to read directory from this project only no need to provide path 
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader("~ReadWriteFile.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
