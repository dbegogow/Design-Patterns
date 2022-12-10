namespace Proxy;

internal class SecuredDoor
{
    private IDoor _door;

    public SecuredDoor(IDoor door)
        => this._door = door ?? throw new ArgumentNullException(nameof(door), "door can not be null");

    public void Open(string password)
    {
        if (this.Authenticated(password))
        {
            this._door.Open();
            return;
        }

        Console.WriteLine("Big no! It ain't possible.");
    }

    public void Close()
        => this._door.Close();

    private bool Authenticated(string password)
        => password == "$ecr@t";
}
