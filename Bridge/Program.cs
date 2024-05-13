// See https://aka.ms/new-console-template for more information
//Real Problem: suppose we are wrting a remote control class library that will control sveral devices such as SamsungTV, SonyTV, Movie, etc.

using Bridge;
using Bridge.Solution;


//without using the pattern
Bridge.SonyRemoteControl remoteControl1 = new();
remoteControl1.TurnOn();




//with Bridge patern
Bridge.Solution.RemoteControl remoteControl = new(new SonyTV()); //you can change it to SamsungTV type
remoteControl.TurnOn();




