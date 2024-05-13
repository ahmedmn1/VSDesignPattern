using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pull
{
    public class DataSourceP:Subject
    {
		private int _custemerSales;

		public int Sales
		{
			get { return _custemerSales; }
			set 
			{
				_custemerSales = value;
                NotifyObservers();
            }
		}


        private string _customerName;

		public string CustomerName
        {
            get => _customerName;
            set
            {
                _customerName = value;
                NotifyObservers();
            }
        }



    }
}
