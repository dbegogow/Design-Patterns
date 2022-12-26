namespace Visitor;

internal class Lion : IAnimal
{
    public void Roar()
    {
        Console.WriteLine("Roaar!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitLion(this);
    }
}
