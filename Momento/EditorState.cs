namespace Momento
    // class that holds editor state, may be text, color, font... etc
{
    public class EditorState
    {

        public EditorState(string content, string color="black")
        {
            Content = content;
            Color = color;
        }

        public string Content { get; private set; }

        public string Color { get; private set; }
    }
}
