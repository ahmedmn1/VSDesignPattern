using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacroryAbstract.WithPattern.Material
{
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MaterialTextBox();
        }
    }
}
