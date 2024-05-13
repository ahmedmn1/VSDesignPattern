//Problem:  We are going to implement a CloudStream class that write and read from cloud hosting.
//aditional requirment came that we need to encrypt the data before storing it .. we can create another class inherited from CloudStream overwite write method
//aditional requirment came that we need to compress the data before storing it .. same solution
//aditional requirment came that we need to compress the data before storing it .. same solution
//Note: to learn about inheritance and override methods at : https://www.geeksforgeeks.org/c-sharp-method-overriding/
// issue here whenever we add a new behvior (compress or encrypt) to cloudStream we need to add new class!
//Decorator pattern enable us to add additional behavior to our existing object

using Decorator;
using Decorator.Solution;
using System.Security.Cryptography;


//using inheritance
Decorator.CloudStream cloudStream2 = new();
Decorator.CompressedCloudStream cloudStream = new();
cloudStream.Write("Mohamed Nabil");

//Using Decorator Pattern
StoreCreditCard(new Decorator.Solution.CloudStream());
StoreCreditCard(new Decorator.Solution.CompressedCloudStream(new Decorator.Solution.CloudStream()));
StoreCreditCard(new Decorator.Solution.EncryptedCloudStream(new Decorator.Solution.CompressedCloudStream(new Decorator.Solution.CloudStream())));



void StoreCreditCard(IStream stream) 
{
    stream.Write("1254-56548-32111-5568");
};




