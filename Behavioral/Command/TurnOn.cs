namespace Command;

internal class TurnOn : ICommand
{
    private Bulb _bulb;

    public TurnOn(Bulb bulb)
        => this._bulb = bulb ?? throw new ArgumentNullException(nameof(bulb), "Bulb cannot be null");

    public void Execute()
        => this._bulb.TurnOn();

    public void Undo()
        => this._bulb.TurnOff();

    public void Redo()
        => this.Execute();
}
