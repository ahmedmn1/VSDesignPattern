using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pull
{
    public class ExcelSheet1P(DataSourceP dataSourceP) : IObserver
    {
        private readonly DataSourceP _dataSourceP = dataSourceP;

        public void Update()
        {
            Console.WriteLine("Sheet1 got notified with just Sales= " + _dataSourceP.CustomerSales);
        }
    }
}
