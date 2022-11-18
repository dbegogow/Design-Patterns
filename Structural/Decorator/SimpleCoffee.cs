namespace Decorator;

internal class SimpleCoffee : ICoffee
{
    public int GetCost()
        => 5;

    public string GetDescription()
        => "Simple Coffee";
}
