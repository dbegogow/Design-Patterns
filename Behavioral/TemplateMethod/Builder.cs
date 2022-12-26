namespace TemplateMethod;

abstract class Builder
{
    public void Build()
    {
        this.Test();
        this.Lint();
        this.Assemble();
        this.Deploy();
    }

    abstract public void Test();

    abstract public void Lint();

    abstract public void Assemble();

    abstract public void Deploy();
}
