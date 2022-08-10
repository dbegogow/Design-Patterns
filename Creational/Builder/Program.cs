namespace Builder;

internal class Program
{
    static void Main()
    {
        var burger = new BurgerBuilder(4)
            .AddCheese()
            .AddPepperoni()
            .AddLettuce()
            .AddTomato()
            .Build();

        Console.WriteLine(burger.GetDescription());
    }
}