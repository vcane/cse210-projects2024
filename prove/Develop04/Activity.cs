public class Activity
{

  private string _welcomeMessage = "\nWelcome to the";
  private string _description = "\nThis activity will help you";
  private int _duration;
  private string _congratulate = "Good job!";

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
    return $"You have completed another {_duration} seconds of the";
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
    Console.Write("How long, in seconds, would you like your session? ");
    _duration = int.Parse(Console.ReadLine());
  }

  public void SpinnerPause()
  {
    DateTime spinnerStart = DateTime.Now;
    DateTime spinnerEnd = spinnerStart.AddSeconds(5);
    int i = 0;
    List<string> animations = new List<string>() { "x", "+" };
    while (DateTime.Now < spinnerEnd)
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
