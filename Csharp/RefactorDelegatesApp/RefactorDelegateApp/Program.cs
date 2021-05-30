using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string > DPrintMessage;
            DPrintMessage = PrintHello;
            DPrintMessage("Onkar");

            DPrintMessage = PrintGoodBye;
            DPrintMessage("Hiren");

            // message = foo;

            Action<string> multiMessage;
            multiMessage = PrintHello;
            multiMessage += PrintGoodBye;
            multiMessage += PrintHello;
            multiMessage("Ratnesh");

            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);

        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello says {0}{1}", name, name);
        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Good Bye Says{0}", name);
        }
        static void foo()
        {

        }
        static void PrintWizard(Action<string> message)
        {
            Console.WriteLine("inside print wizard");
            message("Champ");
        }
    }
}
