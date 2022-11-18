namespace Composite;

internal class Designer : IEmployee
{
    private string _name;
    private float _salary;

    public Designer(string name, float salary)
    {
        this._name = name;
        this._salary = salary;
    }

    public float GetSalary()
        => this._salary;

    public string GetRole()
        => "Designer";

    public string GetName()
        => this._name;
}
