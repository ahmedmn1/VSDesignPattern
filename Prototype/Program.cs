//Real problem, we want to implement part of power point app, which you can add a shape
//to a slide and right click on it then select duplicate

using Prototype;

//without pattern
Circle circle = new ();
circle.Raduis = 1.2f;
MenuContext menuContext = new ();
menuContext.Duplicate(circle);


Console.WriteLine("********* Using the Pattern ***********");

//with pattern: we use it to create new objects by copying an exisitng object
Prototype.Solution.Circle circle1 = new ();
circle1.Raduis = 3.254f;
Prototype.Solution.MenuContext menuContext2 = new ();
menuContext2.Duplicate(circle1);