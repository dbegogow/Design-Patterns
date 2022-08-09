namespace FactoryMethod;

internal class MarketingManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
        => new CommunityExecutive();
}
