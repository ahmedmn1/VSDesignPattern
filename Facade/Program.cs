//benifit: we use it to provide a simple interface to a complex system
//Real Example: we are gonna develop a mobile app and part of it is to push notification to our users.

using Facade;

//Problem:-
//- every time we need to push a message to a user we have to follow all of these steps!
//- this program main class coupled to many classes (message, AuthToken, Connection, notificaionServer)
//- if 10 classes is gonna use this, they also will be coupled to the four classes above. and if we changed one of these four classes
////we have to change the code of the 10 classes! we wanna reduce coupling

//create a notification server
NotificationServer notificationServer = new();
//Connect
Connection connection = notificationServer.Connect("Ip Address");
//Authenticate
AuthToken authToken = notificationServer.Authenticate("appId", "key");
Message message = new("Hello World");
//send a message
notificationServer.Send(authToken, message,"trgetDevice");
//disconnect
notificationServer.Disconnect();

//***using Facade pattern***
NotificationService notificationService = new ();
notificationService.Send("Hello world with Facade", "target Device");





