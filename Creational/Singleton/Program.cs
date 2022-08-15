namespace Singleton;

internal class Program
{
    static void Main()
    {
        var a = President.GetInstance();
        var b = President.GetInstance();

        Console.WriteLine(a == b);
    }
}