using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CloudStream
    {
        public virtual void Write(string data) => Console.WriteLine("Writing " + data + " to the cloud hosting");
    }
}
