using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationServer
    //steps to send notifications
    //connect() -> Connection
    //authenticate (appID, key) -> AuthToken
    //send (authToken, message, target)
    //conn.disconnect()
    {

        public Connection Connect(string ipAddress)
        {
            return new();
        }

        public void Disconnect()
        {

        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new();
        }

        public void Send(AuthToken authToken, Message message, string target) 
        {
            Console.WriteLine("Sending a message:" + message.Content);
        }
    }
}
