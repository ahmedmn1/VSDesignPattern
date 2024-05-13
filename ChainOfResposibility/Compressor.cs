using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class Compressor(Handler next) : Handler(next)
    {
        //couldn't be accessed by the client
        override protected bool DoHandle(HttpRequest request)
        {
            //take the request and handle it then return false to go to the next handler
            Console.WriteLine("Compression");
            return false;
        }
    }
}
