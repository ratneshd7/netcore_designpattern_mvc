using System;
namespace DLLAccountApp.BusinessAccounts
{
   public class CurrentAccount:Account
    {
        const double OVERDRAFT = 2000;
      public  CurrentAccount(string accno, string name, double balance, CardType card) :
            base(accno, name, balance, card)
        {
        }
        public CurrentAccount(string accno, string name) : 
            this(accno, name, 500 + OVERDRAFT, CardType.VISA)
        {
        }
        public override void Deposite(double amount)
        {
            Balance = Balance + amount;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Console.WriteLine("Transaction Completed Successfully");
                Balance = Balance - amount;
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }
}
