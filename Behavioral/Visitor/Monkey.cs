namespace Visitor;

internal class Monkey : IAnimal
{
    public void Shout()
    {
        Console.WriteLine("Oooh o aa aa!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitMonkey(this);
    }
}
