using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pull
{
    public class PChartP(DataSourceP dataSourceP) : IObserver
    {
        private readonly DataSourceP _dataSourceP = dataSourceP;

        public void Update()
        {
            Console.WriteLine("CahrtP got notified with just Custome Name= " + _dataSourceP.CustomerName);
        }
    }
}
