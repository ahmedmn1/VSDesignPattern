//to manage state


namespace Momento
{
    public class History
    {
        private readonly IList<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        //retreive last state and delete it after that
        public EditorState Pop()
        {
            var lastIndex = _states.Count - 1;
            var lastState = _states[lastIndex];
            _states.RemoveAt(lastIndex);
            return lastState;
        }
    }
}
