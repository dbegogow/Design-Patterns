namespace Memento;

internal class Editor
{
    private string _content = string.Empty;
    private EditorMemento _memento;

    public Editor()
        => this._memento = new EditorMemento(string.Empty);

    public void Type(string words)
        => this._content = string.Concat(this._content, " ", words);

    public string Content
        => this._content;

    public void Save()
        => this._memento = new EditorMemento(this._content);

    public void Restore()
        => this._content = this._memento.Content;
}
