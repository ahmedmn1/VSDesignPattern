using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.HTMLEditor
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        //need to hide this method from showing it on the consumer
        internal void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }

        internal void MakeUnderline()
        {
            Content = "<ul>" + Content + "</ul>";
        }
    }
}
