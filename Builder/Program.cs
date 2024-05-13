// See https://aka.ms/new-console-template for more information
//Builder pattern: benifit, to separate the construction (the exporting logic here the logic for constructing the presentation) of an object from its representation
//(presentation or target format) 
// to separate the exporting logic from the presentation format
//because the same exporting logic applies on differernt presentation format 


using Builder;
using Builder.Solution;

Presentation presentation = new();

presentation.AddSlide(new Slide { Text = "Slide 01" });
presentation.AddSlide(new Slide { Text = "Slide 02" });

var pdfBuilder = new PdfDocumentBuilder();
presentation.Export(pdfBuilder);
var pdfDoc= pdfBuilder.GetPdfDocument();

var movieBuilder = new MovieBuilder();
presentation.Export(movieBuilder);
var movieDoc = movieBuilder.GetMovieDocument();
