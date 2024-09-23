// See https://aka.ms/new-console-template for more information

using Comosite;

Group group1 = new();
group1.Add(new Shape()); //Square1
group1.Add(new Shape()); //Square2

Group group2 = new();
group2.Add(new Shape()); //Circle1
group2.Add(new Shape()); //Circle2


Group group3 = new();
group3.Add(group1);
group3.Add(group2);

group3.Render();




