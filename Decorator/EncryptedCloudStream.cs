using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncryptedCloudStream:CloudStream
    {
        public override void Write(string data)
        {
            var encData = Encrypt(data);
            base.Write(encData);
        }

        private string Encrypt(string data) => "#sd$$%sdkk$$HH";

    }
}
