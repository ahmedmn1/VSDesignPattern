//Problem: if we want to change the initernals of the browseHistory class (List used in GetUrls method to Array) we have to
//change the code on the consumer the iterator came to solve this issue 
//We are going to change the implementation on BrowseHistory class- createIterator method  and add arrayIterator class 

using IteratorPattern;

BrowseHistory history = new();
history.Push("A");
history.Push("B");
history.Push("C");
history.Push("D");
history.Push("E");
history.Push("F");
history.Push("G");

//>> we don't need this anymore as it used list methods and if we changed brwoseHistory internal to use array we have to change this cosumer
//for (int i = 0; i < history.GetUrls.Count; i++)
//{
//    Console.WriteLine(history.GetUrls[i]);
//}

//if we change the internal of browseHistory.CreateIterator this code will not affected as we program against interface >>>important
IIterator<string> iterator = history.CreateIterator();

//if we change the internal of browseHistory class this code will not affected
while (iterator.HasNext()) //loop through the list or the attay
{
    var url = iterator.Current();
    Console.WriteLine(url);
    iterator.Next();
}





