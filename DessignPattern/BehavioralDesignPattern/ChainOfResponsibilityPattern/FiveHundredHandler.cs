using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class FiveHundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 500;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 500;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProcessed);
            }
        }
    }
}
