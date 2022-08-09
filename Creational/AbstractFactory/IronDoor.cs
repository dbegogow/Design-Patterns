namespace AbstractFactory;

internal class IronDoor : IDoor
{
    public void GetDescription()
    {
        Console.WriteLine("I am a iron door");
    }
}
