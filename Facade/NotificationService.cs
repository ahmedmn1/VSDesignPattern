using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //this is the facade interface that will be talk directly to the complex systems and its many classes which is coupled to them
    // so any class can use just the send method (simple interface) to talk to this complex system and if any change to the internal classes of this complex
    //system other called classes wont change, just this facade will change (one place)
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            //create a notification server
            NotificationServer notificationServer = new();
            //Connect
            Connection connection = notificationServer.Connect("Ip Address");
            //Authenticate
            AuthToken authToken = notificationServer.Authenticate("appId", "key");
            //send a message
            notificationServer.Send(authToken, new Message(message), target);
            //disconnect
            notificationServer.Disconnect();
        }
    }
}
