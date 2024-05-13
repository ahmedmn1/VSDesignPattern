using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public class PChart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Chart got Notified with Value= " + value );
        }
    }
}
