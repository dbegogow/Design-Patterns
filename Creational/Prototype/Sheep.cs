namespace Prototype;

internal class Sheep
{
    public Sheep(string name, string category)
    {
        this.Name = name;
        this.Category = category;
    }

    public string Name { get; set; }

    public string Category { get; set; }

    public Sheep Child { get; set; }

    public Sheep Clone()
        => MemberwiseClone() as Sheep;
}
