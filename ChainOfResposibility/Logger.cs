using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class Logger(Handler next) : Handler(next)
    {
        override protected bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");
            return false;
        }


    }
}
