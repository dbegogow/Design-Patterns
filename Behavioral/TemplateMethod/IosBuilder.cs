namespace TemplateMethod;

internal class IosBuilder : Builder
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling the ios build");
    }

    public override void Deploy()
    {
        Console.WriteLine("Deploying ios build to server");
    }

    public override void Lint()
    {
        Console.WriteLine("Linting the ios code");
    }

    public override void Test()
    {
        Console.WriteLine("Running ios tests");
    }
}
