using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Solution
{
    //this is part of implementation hirarichy
    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int chNumber);
    }
}
