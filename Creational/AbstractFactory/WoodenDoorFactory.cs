namespace AbstractFactory;

internal class WoodenDoorFactory : IDoorFactory
{
    public IDoor MakeDoor()
        => new WoodenDoor();

    public IDoorFittingExpert MakeFittingExpert()
        => new Carpenter();
}
