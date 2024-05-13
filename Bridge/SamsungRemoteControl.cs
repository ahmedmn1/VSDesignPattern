using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SamsungRemoteControl : RemoteControl
    {
        public override void TurnOff()
        {
            //here we are gonna to talk to a 3rd party library for sony
            Console.WriteLine("Sony TurnOff");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony TurnOn");

        }
    }
}
