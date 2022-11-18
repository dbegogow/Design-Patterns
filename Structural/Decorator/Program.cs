namespace Decorator;

internal class Program
{
    static void Main()
    {
        var myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetCost():c}");
        Console.WriteLine(myCoffee.GetDescription());

        var milkCoffee = new MilkCofee(myCoffee);
        Console.WriteLine($"{milkCoffee.GetCost():c}");
        Console.WriteLine(milkCoffee.GetDescription());

        var whipCoffee = new WhipCoffee(milkCoffee);
        Console.WriteLine($"{whipCoffee.GetCost():c}");
        Console.WriteLine(whipCoffee.GetDescription());

        var vanillaCoffee = new VanillaCoffee(whipCoffee);
        Console.WriteLine($"{vanillaCoffee.GetCost():c}");
        Console.WriteLine(vanillaCoffee.GetDescription());
    }
}