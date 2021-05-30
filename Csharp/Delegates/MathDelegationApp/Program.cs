using System;

namespace MathDelegationApp
{
    public delegate void DmathOperation(int no1, int no2);
    class Program
    {
       
        static void Main(string[] args)
        {
            MathWizard(Add);//named Function

            DmathOperation multioperation;
            multioperation = null;
            multioperation += Add;
            multioperation += Sub;
            multioperation += Multiply;

            Console.WriteLine("list has {0} methods.", multioperation.GetInvocationList().Length);

            multioperation(30, 10);

            MathWizard(delegate (int x, int y){ //Annonymous function
                Console.WriteLine("Mode is {0}%{1}={2}", x, y, x%y);
            });

            MathWizard((x, y) => Console.WriteLine("Division is {0}/{1}={2}", x, y, x / y));
        }
        static void Add(int x,int y)
        {
            Console.WriteLine("Addoition is {0}+{1}={2}",x,y,x+y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction is {0}-{1}={2}", x, y, x - y);
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine("Addoition is {0}*{1}={2}", x, y, x*y);
        }
        static void MathWizard(DmathOperation operation)
        {
            operation(20,10);
        }
    }
}
