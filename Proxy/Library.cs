using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Library
    {
        Dictionary<string, Ebook> _ebooks = new();

        public void Add (Ebook book)
        {
            _ebooks.Add(book.FileName, book);
        }

        public void OpenEbook(string fileName) 
        {
            _ebooks[fileName].Show();
        }
        

    }
}
