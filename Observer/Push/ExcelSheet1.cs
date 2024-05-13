using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public class ExcelSheet1 : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Sheet1 got notified with value= " + value);
        }
    }
}
