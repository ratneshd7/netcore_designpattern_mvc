using System;
using DLLAccountApp.BusinessAccounts;
namespace AccountConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount("81244444","Ratnesh");
            PrintInfo(sa);
        }
        static void PrintInfo(Account acc)
        {
            //Console.WriteLine();
            Console.WriteLine("Account Holder's Name: " + acc.Name + "\n" + "Account No: " + acc.AccountNo + "\n" + "Balance: " + acc.Balance + "\n" + "CardType:" + acc.Card + "\n");

        }
    }
}
