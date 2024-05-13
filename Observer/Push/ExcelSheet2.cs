using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    internal class ExcelSheet2 : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Sheet2 got notified with value= " + value);
        }
    }
}
