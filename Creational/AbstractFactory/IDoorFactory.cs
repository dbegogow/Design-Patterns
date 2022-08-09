namespace AbstractFactory;

internal interface IDoorFactory
{
    IDoor MakeDoor();

    IDoorFittingExpert MakeFittingExpert();
}
