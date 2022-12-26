namespace Observer;

internal class Program
{
    static void Main()
    {
        var johnDoe = new JobSeeker("John Doe");
        var janeDoe = new JobSeeker("Jane Doe");

        var jobPostings = new JobPostings();
        jobPostings.Subscribe(johnDoe);
        jobPostings.Subscribe(janeDoe);

        jobPostings.AddJob(new JobPost("Software Engineer"));
    }
}