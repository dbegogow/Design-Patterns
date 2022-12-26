namespace Observer;

internal class JobPost
{
    public JobPost(string title)
        => this.Title = title;

    public string Title { get; private set; }
}
