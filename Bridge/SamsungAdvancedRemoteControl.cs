using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("Sony SetChannel");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Sony TurnOff");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony TurnOn");
        }
    }
}
