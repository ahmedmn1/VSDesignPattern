using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Solution
{
    public class CompressedCloudStream:IStream
    {
        private readonly IStream _stream;

        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressedData = Compress(data);
            _stream.Write(compressedData);
        }

        private string Compress(string data) =>  "Compressed " + data; 
        
    }
}
