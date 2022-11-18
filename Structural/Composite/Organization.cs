namespace Composite;

internal class Organization
{
    private List<IEmployee> _employees;

    public Organization()
        => this._employees = new List<IEmployee>();

    public void AddEmployee(IEmployee employee)
        => this._employees.Add(employee);

    public float GetNetSalaries()
    {
        var netSalary = 0f;

        foreach (var e in _employees)
        {
            netSalary += e.GetSalary();
        }

        return netSalary;
    }
}
