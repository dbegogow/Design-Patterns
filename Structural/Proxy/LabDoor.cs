namespace Proxy;

internal class LabDoor : IDoor
{
    public void Close()
    {
        Console.WriteLine("Closing lab door!");
    }

    public void Open()
    {
        Console.WriteLine("Opening lab door");
    }
}
