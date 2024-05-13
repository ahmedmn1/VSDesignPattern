using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    //Note we can loosly copuled this class from its services (authenticator, logger, etc.) by using interface and dependency injecion
    // but it will break the Open for extenstion closed for modification principle as if we have to disable one service we have to modify this code.

    public class WebServer(Handler handler)
    {
        private readonly Handler _handler = handler;

        public void Handle(HttpRequest httpRequest)
        {
            //without using this pattern
            ////Authentication
            //var authenticator = new Authenticator();
            //authenticator.Authenticate(httpRequest);
            ////Compression
            //var compressor = new Compressor();
            //compressor.Compress(httpRequest);
            ////Logging
            //var logger= new Logger();
            //logger.Log(httpRequest);

            _handler.Handle(httpRequest);


        }

    }
}
