namespace Builder;

internal class BurgerBuilder
{
    public BurgerBuilder(int Size)
    {
        this.Size = Size;
    }

    public int Size;

    public bool Cheese;

    public bool Pepperoni;

    public bool Lettuce;

    public bool Tomato;

    public BurgerBuilder AddCheese()
    {
        this.Cheese = true;
        return this;
    }

    public BurgerBuilder AddPepperoni()
    {
        this.Pepperoni = true;
        return this;
    }

    public BurgerBuilder AddLettuce()
    {
        this.Lettuce = true;
        return this;
    }

    public BurgerBuilder AddTomato()
    {
        this.Tomato = true;
        return this;
    }

    public Burger Build()
        => new Burger(this);
}
