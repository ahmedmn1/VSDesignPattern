using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacroryAbstract.WithPattern
{
    public interface IWidgetFactory
    {
        //note that these members are interfaces
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
