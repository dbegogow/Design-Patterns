namespace Prototype;

internal class Program
{
    static void Main()
    {
        var original = new Sheep("Jolly", "Mountain Sheep");

        Console.WriteLine(original.Name);
        Console.WriteLine(original.Category);

        original.Child = new Sheep("Holly", "Mountain Sheep");

        var cloned = original.Clone();
        cloned.Name = "Dolly";
        Console.WriteLine(cloned.Name);
        Console.WriteLine(cloned.Category);
        Console.WriteLine(original.Name);
    }
}