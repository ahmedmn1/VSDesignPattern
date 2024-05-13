    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnTemp
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore ( EditorState state ) 
        { 
            Content = state.Content;
        }
    }
}
