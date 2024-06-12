//real ex: we want to develop a gui framework which has widgets like button, listbox, textbox etc. and we want these widget
//apear on diferent theme (theme like material design, etc), so we have group of widget that work with Material design, and second work with Ant etc.
//Abstract Factory  Pattern: Provide an interface for creating families of related objects

//without pattern
using Builder;
using FacroryAbstract.WithPattern.Material;

FacroryAbstract.WithoutPattern.APP.ContactForm contactForm = new();
FacroryAbstract.WithoutPattern.APP.ContactForm.Render(theme:Theme.Material);

Console.WriteLine("************* Using Pattern *************");

//using pattern
FacroryAbstract.WithPattern.APP.ContactForm contactFormP = new();
FacroryAbstract.WithPattern.APP.ContactForm.Render(new MaterialWidgetFactory());
