namespace Observer;

internal class JobSeeker : IObserver<JobPost>
{
    public JobSeeker(string name)
        => this.Name = name;

    public string Name { get; private set; }

    public void OnCompleted()
    {
    }

    public void OnError(Exception error)
    {
    }

    public void OnNext(JobPost value)
    {
        Console.WriteLine($"Hi {Name} ! New job posted: {value.Title}");
    }
}
