using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }
        public void clickOpen()
        {
            openCommand.Execute();
        }
        public void clickSave()
        {
            saveCommand.Execute();
        }
        public void clickClose()
        {
            closeCommand.Execute();
        }
    }
}
