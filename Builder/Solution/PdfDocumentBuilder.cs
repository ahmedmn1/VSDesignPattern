using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Solution
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument _pdfDocument = new();
        public void AddSlide(Slide slide)
        {
            _pdfDocument.AddPage(slide.Text);
        }

        public PdfDocument GetPdfDocument()
        {
            return _pdfDocument;
        }
    }
}
