using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public class DataSource:Subject
    {
        private int _myVar;

		public int Value
		{
			get { return _myVar; }
			set 
			{
				_myVar = value;
                NotifyObservers(value);
            }
		}

	}
}
