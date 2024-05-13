using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Solution
{
    public class Library
    {
        Dictionary<string, IEbook> _ebooks = new();

        public void Add (IEbook book)
        {
            _ebooks.Add(book.FileName, book);
        }

        public void OpenEbook(string fileName) 
        {
            _ebooks[fileName].Show();
        }
        

    }
}
