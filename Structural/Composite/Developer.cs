namespace Composite;

internal class Developer : IEmployee
{
    private string _name;
    private float _salary;

    public Developer(string name, float salary)
    {
        this._name = name;
        this._salary = salary;
    }

    public float GetSalary()
        => this._salary;

    public string GetRole()
        => "Developer";

    public string GetName()
        => this._name;
}
