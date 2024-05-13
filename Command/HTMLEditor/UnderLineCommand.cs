using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.HTMLEditor
{
    public class UnderLineCommand:IUndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _document;
        private History _history;

        public UnderLineCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeUnderline();
            _history.Push(command: this);
        }

        public void UnExecute()
        {
            _document.Content = _prevContent;
        }
    }
}
