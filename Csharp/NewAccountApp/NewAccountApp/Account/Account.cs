namespace NewAccountApp.Account
{
    abstract class Account
    {
        private readonly string _accountNo;
        private readonly string _name;
        private double _balance;
        private CardType _card;

        public Account(string accountno,string name,double balance,CardType card)
        {
            _accountNo = accountno;
            _name = name;
            _balance = balance;
            _card = card;
        }
        public Account(string accountno, string name):this(accountno, name, 500, CardType.VISA)
        {

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
        public CardType Card
        {
            get
            {
                return _card;
            }
        }
        public abstract void Deposite(double amount);

        public abstract void Withdraw(double amount);
        
    }
}
