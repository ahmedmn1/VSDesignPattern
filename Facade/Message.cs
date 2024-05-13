using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Message(string content)
    {
        private readonly string _content = content;



        public string Content 
        { 
            get 
            {
                return _content;
            } 
        }
    }
}
