using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Solution
{
    public class LoggingEbookProxy : IEbook
    {

        private RealEbook _realEbook;

        public LoggingEbookProxy(string _fileName)
        {
            this.FileName = _fileName;
        }

        public string FileName { get ; set ; }

        public void Show()
        {
            if (_realEbook == null) 
            {
                _realEbook = new(this.FileName);
            }
            Console.WriteLine("Logging goes here before loading showing the file");
            _realEbook.Show();

        }
    }
}
