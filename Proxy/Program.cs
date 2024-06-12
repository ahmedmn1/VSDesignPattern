
//Readl ex: We are going to develop an app for reading ebooks, and we have a library that contains all ebooks that we have bought 
//when user loads our app, the app load our ebook library by getting book filename from a DB (array here). then when our library loaded
//user should click on a book to show it

//the issue here is that suppose we have 1000 ebooks, each time the program load it should load all ebooks by reading them from the disk
//and load it to the memory, keep in mind user will  just open one book! it is very memory cost! so we can use a proxy for the ebook instead

//proxy will simulate a real ebook AND IT IS GONNA LOAD THIS EBBOK ON DEMAND ONLY WHEN NEEDED

using Proxy;
using Proxy.Solution;

Console.WriteLine("without using pattern");
Proxy.Library library = new();

//suppose we read fileNames from DB
string[] fileNames = ["a", "b", "c"];
foreach (string name in fileNames)
{
    library.Add(new Ebook(name)); // this will use large amount of memory
}
library.OpenEbook(fileName: "a");//simulate open a book by a user


//***Using Pattern***
Console.WriteLine("Using pattern");
Proxy.Solution.Library libraryP = new();
Proxy.Solution.Library libraryPLog = new();
string[] fileNamesP = ["a", "b", "c"];
foreach (string name in fileNamesP)
{
    libraryP.Add(new EbookProxy (name)); // here we added a punch of proxy books with just FileName Prop
}
//Simulate open a book by a user
libraryP.OpenEbook(fileName: "a");
libraryP.OpenEbook(fileName: "b");

Console.WriteLine("Comply with OCP by adding new LoggingEbookProxy class to add more behavior without modifyng the existing classes");
foreach (string name in fileNamesP)
{
    libraryPLog.Add(new LoggingEbookProxy(name));
}

//simulate open a book by a user
libraryPLog.OpenEbook(fileName: "a");
libraryPLog.OpenEbook(fileName: "b");
