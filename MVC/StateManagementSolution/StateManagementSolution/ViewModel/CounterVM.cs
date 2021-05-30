using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateManagementSolution.ViewModel
{
    public class CounterVM
    {
        public int Old { get; set; }
        public int New { get; set; }
        public string SessionID { get; set; }
    }
}