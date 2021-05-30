using System;

namespace SerializationApp.BusinessApp
{
    [Serializable]
    public class Account
    {
        private string _name;
        private string _accountno;
        private double _balance;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Accountno
        {
            get
            {
                return _accountno;
            }

            set
            {
                _accountno = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public Account()//for xml serialization we need Default constructor
        {
            Console.WriteLine("Inside Default Constructor");
        }
        public Account(string name,string accountno,double balance)
        {
            Name = name;
            Accountno = accountno;
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
        public void Deposite(int amount)
        {
            Balance += Balance;
        }

    }
}
