using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;

        protected AbstractRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
