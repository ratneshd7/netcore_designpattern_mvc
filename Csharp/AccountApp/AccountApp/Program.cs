using AccountApp.Banking;
using System;
namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accountArray = new Account[3];
            //Account account = new Account("81244", "Ratnesh", 600);
            accountArray[0]= new Account("81244", "Ratnesh", 600);
            accountArray[1] = new Account("112200117", "Hiren", 800);
            accountArray[2] = new Account("8282882", "Onkar", 700);
            foreach (Account account in accountArray)
            {
                PrintInfo(account);
            }


            try
            {
                accountArray[0].Name = "ravi";
                PrintInfo(accountArray[0]);
            }
           catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

         

            try
            {
                accountArray[0].Withdraw(100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

   

        }
        public static void PrintInfo(Account acc)
        {
            Console.WriteLine("Account No:"+acc.AccountNo+"\n"+"Name:"+acc.Name+"\n"+"Balance:"+acc.Balance + "\n");
        }
    }
}
