namespace SimpleFactory;

internal class Program
{
    static void Main()
    {
        var door = DoorFactory.MakeDoor(80, 30);

        Console.WriteLine($"Height of the door: {door.GetHeight()}");
        Console.WriteLine($"Width of the door: {door.GetWidth()}");
    }
}