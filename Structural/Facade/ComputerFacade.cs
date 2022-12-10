namespace Facade;

internal class ComputerFacade
{
    private readonly Computer _computer;

    public ComputerFacade(Computer computer)
        => this._computer = computer ?? throw new ArgumentNullException(nameof(computer), "computer cannot be null");

    public void TurnOn()
    {
        this._computer.GetElectricShock();
        this._computer.MakeSound();
        this._computer.ShowLoadingScreen();
        this._computer.Bam();
    }

    public void TurnOff()
    {
        this._computer.CloseEverything();
        this._computer.PullCurrent();
        this._computer.Sooth();
    }
}
