// See https://aka.ms/new-console-template for more information
//Problem: we have an image and filter interface, vividFilter and imageView which take an image and apply a filter to it.
//Suppose we have a 3rd party filters library, we need to use its filter classes which has diff interface than our filter
//(that contains apply method)
//
// we use this pattern to convert the interface of this third party (caramel Class) to our custom interface that we made


using Adapter;
using Adapter.AvaFilters;

ImageView imageView = new(new Image());

imageView.Apply(new VividFilter()); //using our own filter
//We couldn't call this ... imageView.Apply(new Caramel()) as the apply expect object that implement our
//IFilter Interface thats why we used Adapter pattern;
imageView.Apply(new CaramelAdapter(new Caramel())); 

