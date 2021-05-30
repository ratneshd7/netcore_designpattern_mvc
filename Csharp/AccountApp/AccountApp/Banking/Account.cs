using System;
using AccountApp.BankingException;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Banking
{
    class Account
    {
        private string _accountNo;
        private string _name;
        private double _balance;

       public Account(string accno, string name, double balance)
        {
            _accountNo = accno;
            _name = name;
            _balance = balance;
        }

        public string AccountNo
        {
            get
            {
                return _accountNo;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 3)
                    _name = value;
                else
                    throw new NameTooShortException("Name should be greater than 3 letter");
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

      public void Deposite(double amt)
        {
            _balance = _balance + amt;
        }

       public void Withdraw(double amt)
        {
                if (_balance - amt > 500)
                    _balance = _balance - amt;
                else
                    throw new MinimumBalance("Minimum Balance should be greater than 500");
        }
       
    }
}
