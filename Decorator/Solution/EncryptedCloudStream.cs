using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Solution
{
    public class EncryptedCloudStream:IStream
    {
        private readonly IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encData = Encrypt(data);
            _stream.Write(encData);
        }

        private string Encrypt(string data) => "#sd$$%sdkk$$HH";

    }
}
