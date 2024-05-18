/*
Class: Resume

Attributes (state):
* _name: string
* _jobs: List<Job>

Methods (behaviors):
* DisplayResume(): void
*/

public class Resume
{
  public string _name = String.Empty;
  public List<Job> _jobs = new List<Job>();

  public Resume()
  {
  }

  public void DisplayResumeDetails()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("Jobs:");
    foreach (Job job in _jobs)
    {
      job.DisplayJobDetails();
    }
  }
}