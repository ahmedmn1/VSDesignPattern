// See https://aka.ms/new-console-template for more information
using Command;
using Command.FX;
using Command.HTMLEditor;


//1- Basic Command Pattern example
Console.WriteLine("*** Basic Command Pattern ***");
var customerService = new CustomerService();
var customerCommand = new AddCustomerCommand(customerService); //the command object here is between the business logic (CustomerService.AddCustomer) and the GUI

var button = new Button(customerCommand);
var button2 = new Button(new AddOrderCommand(new OrderService()));
button.Click();
button2.Click();

//2- Composite Command Example
Console.WriteLine("*** Composite Command Pattern ***");
var compositeCommand = new CompositeCommand();
compositeCommand.Push(new BlackAndWhiteCommnad());
compositeCommand.Push(new ResizeCommand()) ;
compositeCommand.Execute();


//3- Implementing Undo Mechanism using Command pattern, it is more effective than momento due to we don't need to store all exact object states 
// note the command object is playing between UI and businees logic
Console.WriteLine("*** undo Mechanism using Command Pattern ***");
var history = new History();
var document = new HtmlDocument();

document.Content = "Hello World";

//Create a command object somewhere in your app may be in menu item click
var boldCommand = new BoldCommand(document,history);
boldCommand.Execute();
Console.WriteLine(document.Content);

var underLineCommand = new UnderLineCommand(document, history);
underLineCommand.Execute();
Console.WriteLine(document.Content);

underLineCommand.UnExecute(); //unexcute method might be on any part of your code.




//Create a unDo commnad object on another place in your app may be on button click (undo menu item)
// Note the boldCommand and undoCommand are talking to one history object
var undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(document.Content);
undoCommand.Execute();
Console.WriteLine(document.Content);





