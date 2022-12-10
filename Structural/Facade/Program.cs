namespace Facade;

internal class Program
{
    static void Main()
    {
        var computer = new ComputerFacade(new Computer());

        computer.TurnOn();

        Console.WriteLine();

        computer.TurnOff();

        Console.ReadLine();
    }
}