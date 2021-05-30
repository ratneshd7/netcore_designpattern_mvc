using System;
namespace DelegatesApp
{
    public delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage message;
            message = PrintHello;
            message("Onkar");

            message = PrintGoodBye;
            message("Hiren");

            // message = foo;

            DPrintMessage multiMessage;
            multiMessage = PrintHello;
            multiMessage += PrintGoodBye;
            multiMessage += PrintHello;
            multiMessage("Ratnesh");

            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);

        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello says {0}{1}",name,name);
        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Good Bye Says{0}",name);
        }
        static void foo()
        {

        }
        static void PrintWizard(DPrintMessage message)
        {
            Console.WriteLine("inside print wizard");
            message("Champ");
        }
    }
}
