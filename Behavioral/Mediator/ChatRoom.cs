namespace Mediator;

internal class ChatRoom : IChatRoomMediator
{
    public void ShowMessage(User user, string message)
    {
        Console.WriteLine($"{DateTime.Now.ToString("MMMM dd, H:mm")} [{user.GetName()}]:{message}");
    }
}
