using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pull
{
    public class ExcelSheetP(DataSourceP dataSourceP) : IObserver
    {

        private readonly DataSourceP _dataSourceP = dataSourceP;

        public void Update()
        {
            Console.WriteLine("SheetP got notified with just sales= " + _dataSourceP.CustomerSales);
        }
    }
}
