namespace Proxy;

internal class Program
{
    static void Main()
    {
        var door = new SecuredDoor(new LabDoor());

        door.Open("invalid");

        door.Open("$ecr@t");
        door.Close();
    }
}