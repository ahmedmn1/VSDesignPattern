using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class Authenticator(Handler next) : Handler(next) //note: this is a primary constructor that calls the base class handler
    {
        override protected bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authentication");
            return !(request.UserName == "admin" && request.Password == "123");
        }
    }
}
