using NewAccountApp.Account;
using System;

namespace NewAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount("81244","Ratnesh");
            //PrintInfo(sa);
            //sa.Deposite(2000);
            //PrintInfo(sa);
            //sa.Withdraw(500);
            //PrintInfo(sa);

            CurrentAccount ca = new CurrentAccount("12345", "Onkar");
            PrintInfo(ca);
            ca.Withdraw(2500);
            PrintInfo(ca);
        }
        public static void PrintInfo(NewAccountApp.Account.Account acc)
        {
            Console.WriteLine("Account Holder's Name: " + acc.Name+"\n"+"Account No: "+acc.AccountNo + "\n" + "Balance: "+acc.Balance + "\n" + "CardType:"+acc.Card+"\n");
        }
    }
}
