package Momento;

import java.util.ArrayList;
import java.util.List;

public class History {
    private List<EditorState> states = new ArrayList<>();

    public void Push(EditorState state)
    {
        states.add(state);
    }

    public EditorState Pop()
    {
        var lastIndex = states.size() - 1;
        var lastState = states.get(lastIndex);
        states.remove(lastIndex);

        return lastState;
    }
}
