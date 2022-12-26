namespace Visitor;

internal class Program
{
    static void Main()
    {
        var monkey = new Monkey();
        var lion = new Lion();
        var dolphin = new Dolphin();

        var speak = new Speak();

        monkey.Accept(speak);
        lion.Accept(speak);
        dolphin.Accept(speak);
    }
}