// See https://aka.ms/new-console-template for more information
// the problem is that when we implemented the webServer class and need to change the order of execution of the services 
// or delete a service like deleting the authetication service we need to rewrite this webserver class
//Solution: we apply this pattern to create a pipeline where a chain of objects or service are processing a request and this request doesn't have to be http,
//it could be any type of request
//We will build a chain of objets that can handle a request
// main benifit that you can easily create another service to handle a request and add it to the chain or disable one of them here

//procesing pipeline 
// autheticator -> logger -> compressor


using ChainOfResposibility;



//create chain of objects

var compressor = new Compressor(null);
var logger = new Logger(compressor);
var authenticator = new Authenticator(logger);

var server = new WebServer(authenticator); //set first handler in the pipeline
//authenticator.Handle(new HttpRequest("admin", "123")); //it is working also as we already created a chain of objects

server.Handle(new HttpRequest("admin","123"));





