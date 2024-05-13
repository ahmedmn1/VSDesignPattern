namespace Momento
{
    //class that hold text content like word and its text
    // it should support the undo mechanism through restor state
    public class Editor
    {
        public string Content { get; set; }

        public string Color { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content, Color);
        }

        public void RestoreState (EditorState state)
        {
            Content = state.Content;
            Color = state.Color;
        }
    }
}
