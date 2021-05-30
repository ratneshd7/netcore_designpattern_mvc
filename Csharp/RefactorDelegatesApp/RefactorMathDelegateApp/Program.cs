using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMathDelegateApp
{
    class Program
    {

        static void Main(string[] args)
        {
            MathWizard(Add);//named Function

            Action<int, int> multioperation;
            multioperation = null;
            multioperation += Add;
            multioperation += Sub;
            multioperation += Multiply;

            Console.WriteLine("list has {0} methods.", multioperation.GetInvocationList().Length);

            multioperation(20, 10);

            MathWizard(delegate (int x, int y) { //Annonymous function
                Console.WriteLine("Mode is {0}%{1}={2}", x, y, x % y);
            });

            MathWizard((x, y) => Console.WriteLine("Division is {0}/{1}={2}", x, y, x / y));
        }
        static void Add(int x, int y)
        {
            Console.WriteLine("Addoition is {0}+{1}={2}", x, y, x + y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction is {0}-{1}={2}", x, y, x - y);
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine("Addoition is {0}*{1}={2}", x, y, x * y);
        }
        static void MathWizard(Action<int,int> operation)
        {
            operation(20, 10);
        }
    }
}
