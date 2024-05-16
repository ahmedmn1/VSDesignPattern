// See https://aka.ms/new-console-template for more information
//Real Problem: suppose we are wrting a remote control class library that will control several devices such as SamsungTV, SonyTV, Movie, etc.
//we have three types of remotes control. basic (on, off), advanced (set channel), Movie (Play and rewind)

//RemoteControl
//  SonyRemoteControl
//  SamsungRemoteControl
//  AdvancedRemoteControl
//      SonyAdvancedRemoteControl
//      SamsungAdvancedRemoteControl
//Problem we have 2 types of remote controls so if we have new device we need to create 2 new classes inherit from RemoteControl and AdvancedRemoteControl
//if we added a new remote control may be MovieRemoteControl we need to add new classes for each TVBrand etc.
//our librart will explode by too many classes! the reason is that our hirarichy is growing in to dimentions (feature and implementation) see the UML Pic
//With builder pattern you create simple yet powewrful hirarichy of classes


using Bridge;
using Bridge.Solution;


//without using the pattern
Bridge.SonyRemoteControl remoteControl1 = new();
remoteControl1.TurnOn();




//with Bridge patern
Bridge.Solution.RemoteControl remoteControl = new(new SonyTV()); //you can change it to SamsungTV type
remoteControl.TurnOn();

Bridge.Solution.AdvancedRemoteControl advancedRemoteControl = new(new SamsungTV()); //you can change it to SonyTV type
advancedRemoteControl.SetChannel(33);

Bridge.Solution.MovieRemoteControl movieRemoteControl= new(new SamsungTvMovie()); //you can change it to SonyTV type
movieRemoteControl.Pause();



