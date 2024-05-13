using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Solution
{
    public class CloudStream:IStream
    {
        //Concrete implementation
        public void Write(string data) => Console.WriteLine("Writing " + data + " to the cloud hosting");
    }
}
