namespace Visitor;

internal interface IAnimal
{
    void Accept(IAnimalOperation operation);
}
