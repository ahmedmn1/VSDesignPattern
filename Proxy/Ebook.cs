using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Ebook
    {
        //file name is a complete path for the file on the disk
        public string FileName { get; set; }
        
        public Ebook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading ebook to the memory!" + FileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook " + FileName);
        }

    }
}
