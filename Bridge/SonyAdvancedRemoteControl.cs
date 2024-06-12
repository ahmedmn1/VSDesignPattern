using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SamsungAdvancedRemoteControl : AdvancedRemoteControl
    {
        //private readonly SamsungRemoteControl _samsungRemoteControl;

        //public SamsungAdvancedRemoteControl(SamsungRemoteControl samsungRemoteControl)
        //{
        //    _samsungRemoteControl = samsungRemoteControl;
        //}
        public override void SetChannel()
        {
            Console.WriteLine("Sony SetChannel");
        }

        public override void TurnOff()
        {
            //_samsungRemoteControl.TurnOff();
            Console.WriteLine("Sony TurnOff");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony TurnOn");
        }
    }
}
