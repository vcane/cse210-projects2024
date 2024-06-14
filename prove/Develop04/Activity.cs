public class Activity
{

  private string _welcomeMessage = "\nWelcome to the";
  private string _description = "\nThis activity will help you";
  private int _duration;
  private string _congratulate = "Good job!";
  //private string _endMessage = 

  public Activity() { }

  public string GetStartingMessage()
  {
    return _welcomeMessage;
  }

  public string GetDescription()
  {
    return _description;
  }

  public string GetEndMessage()
  {
    return $"You have completed another {_duration} seconds of ";
  }

  public int GetDuration()
  {
    return _duration;
  }

  public string GetCongratulate()
  {
    return _congratulate;
  }
  public void SetDuration()
  {
    //DateTime duration;
    Console.Write("How long, in seconds, would you like your session? ");
    _duration = int.Parse(Console.ReadLine());
    // return DateTime.Now.AddSeconds(seconds);

    //_duration = seconds;
    //return DateTime.Parse(Console.ReadLine());
    //return duration;
  }

  public void SpinnerPause()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(5);
    int i = 0;
    List<string> animations = new List<string>() { "x", "+" };
    while (DateTime.Now < endTime)
    {
      string animation = animations[i];
      Console.Write(animation);
      Thread.Sleep(300);
      Console.Write("\b \b");

      i++;

      if (i >= animations.Count)
      {
        i = 0;
      }
    }
    // Console.WriteLine("Done.");
  }

  public void CountdownPause()
  {
    for (int i = 5; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

  }

}
