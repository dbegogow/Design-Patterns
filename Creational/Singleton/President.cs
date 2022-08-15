namespace Singleton;

internal class President
{
    private static President instance;

    private President()
    {
    }

    public static President GetInstance()
    {
        if (instance == null)
        {
            instance = new President();
        }

        return instance;
    }
}
