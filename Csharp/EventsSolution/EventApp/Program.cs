using System;
namespace EventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("81244","Ratnesh",5000);
            account.OnBalanceChanged += (Account acc)=> Console.WriteLine("PrintingReceipt {0}",account.Balance); 
            account.OnBalanceChanged += (Account acc) => Console.WriteLine("sendingSMS{0},{1}",account.Name,account.Balance);
            account.OnBalanceChanged += (Account acc) => Console.WriteLine("SendingEmail to Account No {0}",account.AccountNo);
            account.Deposite(100);
        }
    }
}
