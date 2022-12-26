namespace Memento;

internal class EditorMemento
{
    private string _content;

    public EditorMemento(string content)
        => this._content = content;

    public string Content => this._content;
}
