﻿namespace AbstractFactory;

internal class WoodenDoorFactory : IDoorFactory
{
    public IDoor MakeDoor()
    {
        return new WoodenDoor();
    }

    public IDoorFittingExpert MakeFittingExpert()
    {
        return new Carpenter();
    }
}
