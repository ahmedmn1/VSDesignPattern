// State Pattern : Allow the object (Canvas) to behave differently (mouse up/down change) when its state (CurrentTool) changes () 

// See https://aka.ms/new-console-template for more information
using StatePattern;

Canvas canvas = new ()
    { CurrentTool = new Brush() };

canvas.MouseDown();
canvas.MouseUp();

//change canvas state
canvas.CurrentTool = new Selection();
canvas.MouseDown();
canvas.MouseUp();



