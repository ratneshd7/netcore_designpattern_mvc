using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingltonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;// to check how many time instance will created
        // private static readonly Singleton singleInstance = new Singleton(); //without lazy loading
        private static readonly Lazy<Singleton> Instancelock =
                    new Lazy<Singleton>(() => new Singleton()); //Using Lazy Loading of objject --lazy loading is always thread safe
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static Singleton GetInstance
        {
            //get
            //{
            //    return singleInstance;//without lazy loading
            //}
            get
            {
                return Instancelock.Value;//with lazy loading use .value to get instance
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
