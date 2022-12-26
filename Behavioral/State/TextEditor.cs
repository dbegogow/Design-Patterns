namespace State;

internal class TextEditor
{
    private IWritingState _state;

    public TextEditor()
        => this._state = new DefaultText();

    public void SetState(IWritingState state)
        => this._state = state;

    public void Type(string words)
        => this._state.Write(words);
}
