using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer
{
    // created by the consumer
    // this is a mediator pattern implemented by observer with delegate action method instead
    public class ArticlesDialogBox //play as observer
    {
        //Note: we can initialize these control easily from outside this class
        private readonly ListBox _articlesListBox = new() ;
        private readonly TextBox _titleTextBox = new ();
        private readonly Button _saveButton = new();

        public ArticlesDialogBox()
        {
            _articlesListBox.AddEventHandler(ArticleSelected);
            _titleTextBox.AddEventHandler(TitleChaged);

        }


        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Mickey Mouse from Mediator-Observer"; //fire the event handler method to start controls communications
            Console.WriteLine("Text Box: " + _titleTextBox.Content);
            Console.WriteLine("Button: " + _saveButton.IsEnabled);


            _titleTextBox.Content = "";
            Console.WriteLine("Text Box: " + _titleTextBox.Content);
            Console.WriteLine("Button: " + _saveButton.IsEnabled);
        }




        private void TitleChaged()
        {
            _saveButton.IsEnabled = !string.IsNullOrWhiteSpace(_titleTextBox.Content);
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.IsEnabled = true;
        }

       
    }
}
