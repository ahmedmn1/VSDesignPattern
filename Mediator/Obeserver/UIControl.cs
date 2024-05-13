using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer
{
    //this class is going to work as a dialog box in the mediator pattern
    public abstract class UIControl //play as subject
    {
        private readonly List<Action> _eventHandlers = [];

        public void AddEventHandler(Action observer)
        {
            _eventHandlers.Add(observer);
        }

        protected void NotifyEventHandlers() //protexted becasue we just want it inside this namespace
        {
            foreach (Action eventHandle in _eventHandlers)
            {
                eventHandle();
            }
        }


        
    }
}
