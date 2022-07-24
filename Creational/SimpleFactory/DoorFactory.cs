namespace SimpleFactory;

internal class DoorFactory
{
    public static IDoor MakeDoor(int height, int width)
        => new WoodenDoor(height, width);
}
