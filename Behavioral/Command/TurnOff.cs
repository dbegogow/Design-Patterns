namespace Command;

internal class TurnOff : ICommand
{
    private Bulb _bulb;

    public TurnOff(Bulb bulb)
        => this._bulb = bulb ?? throw new ArgumentNullException(nameof(bulb), "Bulb cannot be null");

    public void Execute()
        => this._bulb.TurnOff();

    public void Undo()
        => this._bulb.TurnOn();

    public void Redo()
        => this.Execute();
}
