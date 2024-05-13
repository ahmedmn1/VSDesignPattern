// See https://aka.ms/new-console-template for more information

using HandOnTemp;

var editor = new Editor();
var history = new History();


editor.Content = "A";
history.Push(editor.CreateState());

editor.Content = "B";
history.Push(editor.CreateState());

editor.Content = "C";



editor.Restore(history.Pop());



Console.WriteLine(editor.Content);
editor.Restore(history.Pop());
Console.WriteLine(editor.Content);