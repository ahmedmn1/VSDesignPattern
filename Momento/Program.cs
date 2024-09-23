// See https://aka.ms/new-console-template for more information
//Momento provides a way to make undo mechanism

using Momento;

var editor = new Editor();
var history = new History();

editor.Content = "A";
editor.Color = "Red";
history.Push(editor.CreateState());

editor.Content = "B";
editor.Color = "Blue";
history.Push(editor.CreateState());

editor.Content = "C";
editor.Color = "Green";
history.Push(editor.CreateState());

editor.Content = "D";
editor.Color = "Yellow";

//undo command
editor.RestoreState(history.Pop());
Console.WriteLine($"{"Content:" + editor.Content + "  && Color: " + editor.Color}");  //return c and delete it 

editor.RestoreState(history.Pop());
Console.WriteLine($"{"Content:" + editor.Content + "  && Color: " + editor.Color}");  //return B and delete it





