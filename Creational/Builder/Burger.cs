using System.Text;

namespace Builder;

internal class Burger
{
    private int _size;
    private bool _cheese;
    private bool _pepperoni;
    private bool _lettuce;
    private bool _tomato;

    public Burger(BurgerBuilder builder)
    {
        this._size = builder.Size;
        this._cheese = builder.Cheese;
        this._pepperoni = builder.Pepperoni;
        this._lettuce = builder.Lettuce;
        this._tomato = builder.Tomato;
    }

    public string GetDescription()
        => $"This is {this._size} inch Burger.";
}
