//Definiton: Defer the creation of an object to subclasses
//Real example: Suppose that we are going to create WebFramework so other devs will use it to build webApps e.g. ASP.Net MVC, We are gonna call it Matcha
// all these framework has a concept of a template or a view e.g. Template.html, which is an html file that has some logic (code) for rendring data
// most of frame work has an engine to read the template or the view like template.html and return normal html code
//suppose that a dev will use our framework to build a product page
// <>

//Without Pattern
using FactoryMethod;
new ProductsControllerA().ListProducts();

Console.WriteLine("With Factory Method Pattern");
//With Pattern
new ProductsControllerB().ListProducts(); //default implemtation with match engine
new ProductsControllerC().ListProducts(); //







