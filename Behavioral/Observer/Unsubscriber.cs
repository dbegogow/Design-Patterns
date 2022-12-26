namespace Observer;

internal class Unsubscriber<JobPost> : IDisposable
{
    private List<IObserver<JobPost>> _observers;
    private IObserver<JobPost> _observer;

    public Unsubscriber(
        List<IObserver<JobPost>> observers,
        IObserver<JobPost> observer)
    {
        this._observers = observers;
        this._observer = observer;
    }

    public void Dispose()
    {
        if (this._observers.Contains(this._observer))
        {
            this._observers.Remove(this._observer);
        }
    }
}
