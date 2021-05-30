using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Welcome To Command Line App \n Type  -help to see options");
               
            }
            else if (args[0] == "-help")
            {
                Console.WriteLine("-names [A,B,C,....]");
                
            }
            else if (args.Length >= 1)
            {
                char[] spearator = { ',', '[', ']' };
                String [] namesArray = args[1].Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                for (int i= 0;i< namesArray.Length; i++)
                {
                    Console.WriteLine("Hello "+namesArray[i]);
                }              
            }
        }
    }
}
