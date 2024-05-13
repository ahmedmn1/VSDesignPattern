using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Solution
{
    //this is part of feature hirarichy
    public class AdvancedRemoteControl(IDevice device) : Bridge.Solution.RemoteControl(device)
    {
        public void SetChannel(int chNnumber)
        {
            _device.SetChannel(chNnumber);
        }


    }
}
