namespace Mediator;

internal class Program
{
    static void Main()
    {
        var mediator = new ChatRoom();

        var john = new User("John", mediator);
        var pedro = new User("Pedro", mediator);

        john.Send("Hi there!");
        pedro.Send("Hey!");
    }
}