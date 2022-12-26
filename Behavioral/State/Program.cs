namespace State;

internal class Program
{
    static void Main()
    {
        var editor = new TextEditor();

        editor.Type("First line");

        editor.SetState(new UpperCase());

        editor.Type("Second Line");
        editor.Type("Third Line");

        editor.SetState(new LowerCase());

        editor.Type("Fourth Line");
        editor.Type("Fifthe Line");
    }
}