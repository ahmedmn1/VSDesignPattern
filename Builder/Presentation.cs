using Builder.Solution;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Presentation()
    {
        
        private List<Slide> _slidesList = new();

        public void AddSlide(Slide slide)
        {
            _slidesList.Add(slide);
        }


        //the problem in this implemnetation:-
        //1- OCP if we want to support a new export file format we have to change this method
        //2- Tight coupling between Presentation and exported type format (pdf and movie)
        //3- Our presentation class should know how to structure the generated type format (pdf needs addPage, movie needs AddFrame with its params etc.)
        // so as we add more type format this class will cluttered with so much knowledge that realy belongs to somewhere else.
        //4- Code repeatition on our exporting logic on the foreach loop also if we want to add copyright 
        //public void Export(FileType fileType)
        //{
        //    if (fileType == FileType.pdf)
        //    {
        //        PdfDocument pdfDocument = new ();
        //        pdfDocument.AddPage(text: "Copy right");
        //        foreach (var slide in _slidesList)
        //        {
        //            pdfDocument.AddPage(slide.Text);
        //        }
        //    }
        //    else if(fileType == FileType.mpg)
        //    {
        //        Movie movie = new ();
        //        movie.AddFrame(text:"Copy right", 3);
        //        foreach (var slide in _slidesList)
        //        {
        //            movie.AddFrame(slide.Text,3);
        //        }


        //    }
        //}


        public void Export(IPresentationBuilder presentationBuilder)
        {
            presentationBuilder.AddSlide(new Slide {Text="Copy Right"});
            foreach (var slide in _slidesList)
            {
                presentationBuilder.AddSlide(slide);
            }
        }
    }
}
