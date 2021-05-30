using System;

namespace FuncActionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> DPrintName;
            DPrintName = PrintName;
            DPrintName += PrintName;
            DPrintName("Onkar");

            Action<string, string> DFullName = (firstN, lastN) => Console.WriteLine("FirstName : {0} \nLastName : {1} ",firstN,lastN);
            DFullName("Ratnesh", "Dubey");

            Func<int, long> cubeNo = (n) => n * n * n;
            Console.WriteLine(cubeNo(5));

            Predicate<int> isEven = (n) => n % 2 == 0;
            Console.WriteLine(isEven(5));
        }
        static void PrintName(String name)
        {
            Console.WriteLine("Hello "+name);
        }
    }
}
