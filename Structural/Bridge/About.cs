namespace Bridge;

internal class About : IWebPage
{
    protected ITheme _theme;

    public About(ITheme theme)
        => this._theme = theme;

    public string GetContent()
        => $"About page in {this._theme.GetColor()}";
}
