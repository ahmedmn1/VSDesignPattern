import Momento.Editor;
import Momento.History;

public class App {
    public static void main(String[] args) throws Exception {
        // Implement Momento Pattern
        var editor = new Editor();
        var history = new History();

        editor.setContent("a");
        history.Push(editor.createState());

        editor.setContent("b");
        history.Push(editor.createState());

        editor.setContent("c");
        editor.restore(history.Pop()); // should return b here
        editor.restore(history.Pop()); // should return a

        System.out.println(editor.getContent());
    }
}
