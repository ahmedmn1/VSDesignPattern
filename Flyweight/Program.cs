//usage: when we have a large amount of objects which consume  device memory, using this pattern will reduce the amount of memory consumed by
//these objects

//Real example: we are developing app like google map, when we render a pic, we need to show points like cafe, restaurant, etc. with its icon, each
//icon is a pic with 20 kb, if we load a lot of points we are going to hault the memory so how can we share the icons without creating a new one?

using Flyweight;

Console.WriteLine("***Without Pattern***");
PointService pointService = new();
foreach (var point in pointService.GetPoints())
{
    //if this GetPoints returns alot of points this will hault the memory. 
    //how can we imporve it? how we can reduce the amount of memory the app uses?
    point.Draw();
}


//Using Flyweight 
Console.WriteLine("***With Flyweigt Pattern***");
Flyweight.Solution.PointService pointServiceFw = new(new Flyweight.Solution.PointIconFactory());
foreach (var point in pointServiceFw.GetPoints())
{    
    point.Draw();
}