namespace Composite;

internal class Program
{
    static void Main()
    {
        var developer = new Developer("John", 5000);
        var designer = new Designer("Mike", 5000);

        var organization = new Organization();

        organization.AddEmployee(developer);
        organization.AddEmployee(designer);

        Console.WriteLine($"Net salary of Employees in Organization is {organization.GetNetSalaries():c}");
    }
}