namespace Bridge;

internal class Program
{
    static void Main()
    {
        var darkTheme = new DarkTheme();
        var lightTheme = new LightTheme();

        var about = new About(darkTheme);
        var careers = new Careers(lightTheme);

        Console.WriteLine(about.GetContent());
        Console.WriteLine(careers.GetContent());
    }
}