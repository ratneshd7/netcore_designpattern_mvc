using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.BankingException
{
    class MinimumBalance:Exception
    {
        public MinimumBalance(String message) : base(message)
        {
            //Console.WriteLine(message);
        }
    }
}
