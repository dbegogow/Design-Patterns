namespace AbstractFactory;

internal class IronDoorFactory : IDoorFactory
{
    public IDoor MakeDoor()
        => new IronDoor();

    public IDoorFittingExpert MakeFittingExpert()
        => new Welder();
}
