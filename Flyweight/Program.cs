// See https://aka.ms/new-console-template for more information
//usage: when we have a large amount of objects which consum the device memory, using it we can reduce the amount of memory consumed by these objects
//Real example: we ar developing app like google map, when we render a pic, we need to show points like cafe, restaurant, etc.

using Flyweight;

PointService pointService = new();

foreach (var point in pointService.GetPoints())
{
    //if this method render alot of point hat hault the memory how can we imporve it? how we can reducethe amount of memory the app use?
    point.Draw();
}


//using Flyweight 
Flyweight.Solution.PointService pointServiceFw = new(new Flyweight.Solution.PointIconFactory());
foreach (var point in pointService.GetPoints())
{
    //if this method render alot of point hat hault the memory how can we imporve it? how we can reducethe amount of memory the app use?
    point.Draw();
}