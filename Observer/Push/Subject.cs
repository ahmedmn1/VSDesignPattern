using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public class Subject
    {
        private readonly List<IObserver> _observers = [];

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(int value)
        {
            foreach (var observer in _observers)
            {
                observer.Update(value);
            }
        }

    }
}
