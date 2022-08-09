namespace AbstractFactory;

internal class Program
{
    static void Main()
    {
        var woodenDoorFactory = new WoodenDoorFactory();

        var woodenDoor = woodenDoorFactory.MakeDoor();
        var woodenDoorFittingExpert = woodenDoorFactory.MakeFittingExpert();

        woodenDoor.GetDescription();
        woodenDoorFittingExpert.GetDescription();

        var ironDoorFactory = new IronDoorFactory();

        var ironDoor = ironDoorFactory.MakeDoor();
        var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

        ironDoor.GetDescription();
        ironDoorFittingExpert.GetDescription();
    }
}