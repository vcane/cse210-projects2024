class Program
{
  static void Main(string[] args)
  {
    List<Activity> activities = new List<Activity>()
    {
      new Running("7/12/22", 30, 5.1f),
      new Cycling("7/13/24", 30, 10.1f),
      new Swimming("8/1/23", 60, 45)
    };

    foreach (Activity activity in activities)
    {
      Console.WriteLine(activity.SummarizeActivity());
    }
  }
}