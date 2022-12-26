namespace State;

internal class LowerCase : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words.ToLower());
    }
}
