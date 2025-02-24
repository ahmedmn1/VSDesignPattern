using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public abstract class Handler(Handler next)
    {
        private readonly Handler _next = next;

        //template method pattern
        internal void Handle(HttpRequest request)//how to make it just visible in the Framework namespace
        {
            if (DoHandle(request))
                return;
            _next?.Handle(request);

        }

        //if request is already handled and done return true
        protected abstract bool DoHandle(HttpRequest request); //protected means, it is only visible here in the
                                                               //base class and subclass, not accessed by client
    }
}
