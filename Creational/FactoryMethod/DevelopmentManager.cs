namespace FactoryMethod;

internal class DevelopmentManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
        => new Developer();
}
