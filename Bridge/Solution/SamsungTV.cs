using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Solution
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int chNumber)
        {
            Console.WriteLine("Samsung Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung Turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung Turn On");
        }
    }
}
