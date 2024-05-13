using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    //note: when adding method on the interface you should put its signature
    public interface ICompressor
    {
        //byte[] Compress(byte[] data);
        void Compress(string fileName);
    }
}