namespace Decorator;

internal class MilkCofee : ICoffee
{
    private readonly ICoffee _coffee;

    public MilkCofee(ICoffee coffee)
        => this._coffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");

    public int GetCost()
        => this._coffee.GetCost() + 1;

    public string GetDescription()
        => string.Concat(this._coffee.GetDescription(), ", milk");
}
