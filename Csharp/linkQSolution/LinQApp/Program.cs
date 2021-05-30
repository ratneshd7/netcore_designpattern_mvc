using System;
using System.Collections.Generic;
using System.Linq;
 
namespace LinQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();//defered execution of filter
            //Case2();// immediate execution of filter or method
            DisplayNameWhichHasA();
        }

        private static void DisplayNameWhichHasA()
        {
            List<string> customer = new List<string>();
            customer.Add("ratnesh");
            customer.Add("onkar");
            customer.Add("aakash");
            customer.Add("hiren");
            IEnumerable<string> query = customer.Where(c => c.Contains("a"))
                                                .Where(c=>c.Length>2)
                                                .Take(2)
                                                .ToList();
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
            //IEnumerable<string> toptwo = customer.Take(1);
            //foreach (string name in toptwo)
            //{
            //    Console.WriteLine(name);
            //}
        }

        private static void Case1()
        {
            string[] customer = { "abc", "pqrs", "xyz", "lmno" };
            IEnumerable<string> query = customer.Where(c => c.Length > 3);
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }
        private static void Case2()
        {
            List<string> customer = new List<string>();
            customer.Add("abc");
            customer.Add("pqrs");
            customer.Add("lmno");
            IEnumerable<string> query = customer.Where(c => c.Length > 3).ToList();
            customer.Add("jklm");
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
