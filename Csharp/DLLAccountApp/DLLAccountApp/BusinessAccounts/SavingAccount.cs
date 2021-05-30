using System;

namespace DLLAccountApp.BusinessAccounts
{
    public class SavingAccount:Account
    {
         SavingAccount(string accno, string name, double balance, CardType card) :
            base(accno, name, balance, card)
        {
        }
        public SavingAccount(string accno, string name) : this(accno, name, 500, CardType.VISA)
        {
        }
        public override void Deposite(double amount)
        {
            Balance = Balance + amount;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount > 500)
            {
                Balance = Balance - amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

    }
}
