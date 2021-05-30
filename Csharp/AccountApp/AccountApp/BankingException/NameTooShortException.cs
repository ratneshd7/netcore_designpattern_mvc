using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.BankingException
{
    class NameTooShortException:Exception
    {
        public NameTooShortException(String message):base(message)
        {
           // Console.WriteLine(message);
        }
    }
}
