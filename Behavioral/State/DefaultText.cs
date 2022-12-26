namespace State;

internal class DefaultText : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words);
    }
}
