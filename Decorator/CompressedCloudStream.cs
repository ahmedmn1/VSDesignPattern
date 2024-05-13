using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressedCloudStream:CloudStream
    {
        public override void Write(string data)
        {
            var compressedData = Compress(data);
            base.Write(compressedData);
        }

        private string Compress(string data) =>  "Compressed " + data; 
        
    }
}
