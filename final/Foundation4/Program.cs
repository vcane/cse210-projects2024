class Program
{
  static void Main(string[] args)
  {
    List<Activity> activities = new List<Activity>();
    Running running = new Running("7/12/22", 30, 5.1f);
    Cycling cycling = new Cycling("7/13/24", 30, 10.1f);
    Swimming swimming = new Swimming("8/1/23", 60, 45);
    activities.Add(running);
    activities.Add(cycling);
    activities.Add(swimming);

    foreach (Activity activity in activities)
    {
      Console.WriteLine(activity.SummarizeActivity());
    }
  }
}