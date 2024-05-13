using Builder;
using FacroryAbstract.WithoutPattern.ANT;
using FacroryAbstract.WithoutPattern.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacroryAbstract.WithoutPattern.APP
{
    //we have acontact form with button and text box, and you can change the theme using its render method
    //What is the probelms with this implemetnation?
    //Violate the OCP, if we want to support a new them we have to change this code
    //also the consumer might by mistake render MaterialButton while user select Ant theme! 
    public class ContactForm
    {
        public static void Render(Theme theme)
        {
            if (theme == Theme.ANT)
            {
                new AntTextBox().Render();
                new AntButton().Render();
            }
            else if (theme == Theme.Material)
            {
                new MaterialTextBox().Render();
                new MaterialButton().Render();
            }
        }
    }
}
