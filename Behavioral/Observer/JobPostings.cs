using System;

namespace Observer;

internal class JobPostings : IObservable<JobPost>
{
    private List<IObserver<JobPost>> _observers;
    private List<JobPost> _jobPostings;

    public JobPostings()
    {
        this._observers = new List<IObserver<JobPost>>();
        this._jobPostings = new List<JobPost>();
    }

    public IDisposable Subscribe(IObserver<JobPost> observer)
    {
        if (!this._observers.Contains(observer))
        {
            this._observers.Add(observer);
        }

        return new Unsubscriber<JobPost>(this._observers, observer);
    }

    private void Notify(JobPost jobPost)
    {
        foreach (var observer in this._observers)
        {
            observer.OnNext(jobPost);
        }
    }

    public void AddJob(JobPost jobPost)
    {
        this._jobPostings.Add(jobPost);
        this.Notify(jobPost);
    }
}
