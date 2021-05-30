using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILEDTV ledTv) : base(ledTv)
        {
        }
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}
