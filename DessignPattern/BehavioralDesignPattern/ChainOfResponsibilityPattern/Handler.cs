using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        public Handler rsHandler;
        public void nextHandler(Handler rsHandler)
        {
            this.rsHandler = rsHandler;
        }
        public abstract void dispatchRs(long requestedAmount);
    }
}
