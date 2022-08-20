namespace Adapter;

internal class WildDogAdapter : ILion
{
    private WildDog _dog;

    public WildDogAdapter(WildDog dog)
        => this._dog = dog;

    public void Roar()
        => this._dog.bark();
}
