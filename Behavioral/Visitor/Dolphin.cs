namespace Visitor;

internal class Dolphin : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Tuut tittu tuutt!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitDolphin(this);
    }
}
