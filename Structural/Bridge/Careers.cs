namespace Bridge;

internal class Careers : IWebPage
{
    protected ITheme _theme;

    public Careers(ITheme theme)
        => this._theme = theme;

    public string GetContent()
        => $"Careers page in {this._theme.GetColor()}";
}
