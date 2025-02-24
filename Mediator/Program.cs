// See https://aka.ms/new-console-template for more information
//problem: we have a dialog box, that contain a list box, text box and a save button. when user select an item from the list box
// its content should fill the text box and the button enabled. all of these controls should talk to each other
// you are a component developer of these controls how to provide them to other devs without letting then chage thier code?

// Using Mediator Pattern: mediator is the dialog box, exch control will notify the mediator when change occure on control's state by calling
// mediator changed method, in this method you will check which controld chaged and do the logic.
// the problme here with many controls this method will have a lot of decision statements, to solve this we can use observer pattern instead


//Q: how to create a new instance of an object, this object need constructor with param represent an object composed the first object
//as We want to set the state of controls (textbox and list box from the clinet)

using Mediator;
using Mediator.Observer;

Console.WriteLine('\n' + "******** Mediator Pattrn **************");
Mediator.ArticlesDialogBox articlesDialogBox = new();
articlesDialogBox.SimulateUserInteraction();

Console.WriteLine('\n' + "******************* Mediator with observer **********************");
Mediator.Observer.ArticlesDialogBox  articlesDialogBox1 = new();
articlesDialogBox1.SimulateUserInteraction();


