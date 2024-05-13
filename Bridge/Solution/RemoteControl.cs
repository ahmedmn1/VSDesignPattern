using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Basic Remote Control (turnOn, turnOff)
// Advanced Remote Control (setChannel)
// Movie Remote Control (play, pause, rewind)

//Hirarichy Without using the pattern
// RemoteControl
//   SonyRemoteControl
//   AdvancedRemoteControl
//     SonyAdvancedRemoteControl
// 2 types of remote controls -> 2 new classes

//**Issue: every time we want to support new type device we want to add new 2 classes and if we have Movie abstract class we need to add 3 classes!
//our hirarichy will explode over time!
//With builder pattern we will have simple yet flixable hirarichy of classes

namespace Bridge.Solution
{
    //this is part of feature hirarichy
    public class RemoteControl(IDevice device)
    {
        //this filed is the bridge between the two separate hirarichy
        protected readonly IDevice _device = device; //protected modifier to call it from the derived class

        public void TurnOn() 
        {
            _device.TurnOn();
        }
        public void TurnOff() 
        {
            _device?.TurnOff();
        }
    }
}
