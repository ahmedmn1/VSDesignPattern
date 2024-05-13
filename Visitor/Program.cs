// See https://aka.ms/new-console-template for more information




using Visitor;

var htmlDoc= new HTMLDocument();

htmlDoc.AddNode(new AnchorNode());
htmlDoc.AddNode(new HeaderNode());
htmlDoc.Execute(new HighLightOperation());
htmlDoc.Execute(new PlainTextOperation());


