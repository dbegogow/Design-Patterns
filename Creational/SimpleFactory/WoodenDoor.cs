namespace SimpleFactory;

internal class WoodenDoor : IDoor
{
    private int _height;

    private int _width;

    public WoodenDoor(int height, int width)
    {
        this._height = height;
        this._width = width;
    }

    public int GetHeight()
        => this._height;

    public int GetWidth()
        => this._width;
}
