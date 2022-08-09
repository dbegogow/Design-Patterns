namespace FactoryMethod;

internal class Program
{
    static void Main()
    {
        var devManager = new DevelopmentManager();
        devManager.TakeInterview();

        var marketingManager = new MarketingManager();
        marketingManager.TakeInterview();
    }
}