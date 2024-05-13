using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Solution
{
    public class EbookProxy : IEbook
    {
        private RealEbook _realEbook=null;

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }
        public string FileName { get; set; }

        //here we are going to prefrom the lazy loading
        public void Show()
        {
            if (_realEbook == null) 
            {
                _realEbook = new(this.FileName);
            }
            _realEbook.Show();
        }
    }
}
