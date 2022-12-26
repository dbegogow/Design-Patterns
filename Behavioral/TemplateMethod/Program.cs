namespace TemplateMethod;

internal class Program
{
    static void Main()
    {
        var androidBuilder = new AndroidBuilder();
        androidBuilder.Build();

        var iosBuilder = new IosBuilder();
        iosBuilder.Build();
    }
}