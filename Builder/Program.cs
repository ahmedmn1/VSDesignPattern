//Builder pattern: benifit, to separate the construction (the exporting logic here) of an object from its representation (the target format here)
//because the same exporting logic applies on differernt presentation format, meaning that same exporting logic applies to any powerpoint slide that
//might contain many format of slides   


using Builder;
using Builder.Solution;


//without Pattern
Presentation1 presentation1 = new();
presentation1.AddSlide(new Slide { Text = "Slide 01" });
presentation1.AddSlide(new Slide { Text = "Slide 02" });
presentation1.Export(FileType.pdf);
presentation1.Export(FileType.mpg);


//with builder pattern
Presentation presentation2 = new();
presentation2.AddSlide(new Slide { Text = "Slide 01" });
presentation2.AddSlide(new Slide { Text = "Slide 02" });

var pdfBuilder = new PdfDocumentBuilder();
presentation2.Export(pdfBuilder);
var pdfDoc= pdfBuilder.GetPdfDocument();

var movieBuilder = new MovieBuilder();
presentation2.Export(movieBuilder);
var movieDoc = movieBuilder.GetMovieDocument();
