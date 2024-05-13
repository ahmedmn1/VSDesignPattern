using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // created by the consumer
    // this is a mediator pattern
    public class ArticlesDialogBox : DialogBox
    {
        private readonly ListBox _articlesListBox ;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        //we need to implement this mehod outside this class. can we?
        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "MickeyMouse Item Seleted from Mediator";
            Console.WriteLine("Text Box: " + _titleTextBox.Content);
            Console.WriteLine("Button: " + _saveButton.IsEnabled);

            _titleTextBox.Content = "";
            Console.WriteLine("Text Box: " + _titleTextBox.Content);
            Console.WriteLine("Button: " + _saveButton.IsEnabled);
        }

        public ArticlesDialogBox()
        {
            _articlesListBox = new(_dialogBox: this);
            _titleTextBox = new(_dialogBox: this);
            _saveButton = new(_dialogBox: this);
        }
       

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
                ArticleSelected();
            else if (control == _titleTextBox)
                TitleChaged();
            
        }

        private void TitleChaged()
        {
            _saveButton.IsEnabled = !string.IsNullOrWhiteSpace(_titleTextBox.Content);
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;  //should fire Changed method but it didn't!
            _saveButton.IsEnabled = true; //should fire Changed method but it didn't!
        }


    }
}
