namespace Mediator;

internal class User
{
    private string _name;
    private IChatRoomMediator _chatRoom;

    public User(string name, IChatRoomMediator chatroom)
    {
        this._chatRoom = chatroom;
        this._name = name;
    }

    public string GetName()
        => this._name;

    public void Send(string message)
        => this._chatRoom.ShowMessage(this, message);
}
