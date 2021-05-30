
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{

    class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Save();
        }
    }
}
