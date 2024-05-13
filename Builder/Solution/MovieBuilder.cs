using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Solution
{
    public class MovieBuilder :IPresentationBuilder
    {
        private Movie _movie = new();

        public void AddSlide(Slide slide)
        {
            _movie.AddFrame(slide.Text,3);
        }

        public Movie GetMovieDocument()
        {
            return _movie;
        }
    }
}
