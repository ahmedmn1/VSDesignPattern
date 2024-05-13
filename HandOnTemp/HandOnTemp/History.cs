using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnTemp
{
    public class History
    {
        private IList<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        //retrevie the last item and delete it
        public EditorState Pop()
        {
            EditorState lastItem= states[states.Count - 1];
            states.Remove(lastItem);
            return lastItem;
        } 
    }
}
