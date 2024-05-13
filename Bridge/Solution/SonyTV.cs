using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Solution
{
    //this is part of implementation hirarichy
    public class SonyTV : IDevice
    {
        public void SetChannel(int chNumber)
        {
            Console.WriteLine("Sony Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony Set TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony Set TurnOn");
        }
    }
}
