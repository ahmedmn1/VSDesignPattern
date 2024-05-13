using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class HttpRequest(string userName, string password)
    {
        public string UserName { get; set; } = userName;
        public string Password { get; set; } = password;
    }
}
