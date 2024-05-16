using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Solution
{
    public class MovieRemoteControl(IDevice device) : RemoteControl(device)
    {
        public void Play() 
        { 
        }

        public void Stop() 
        {
        
        }

        public void Pause() 
        { 
        
        }


    }
}
