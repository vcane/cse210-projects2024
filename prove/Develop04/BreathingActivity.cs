public class BreathingActivity : Activity
{
  private string _nameBreathing = "Breathing Activity";
  private string _breathingActivityDescription = " relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
  public BreathingActivity() : base() { }



  public void RunBreathingActivity()
  {
    Console.WriteLine(GetStartingMessage() + _nameBreathing);
    Console.WriteLine(GetDescription() + _breathingActivityDescription);
    SetDuration();
    Console.WriteLine("Get ready....");
    SpinnerPause();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      Console.Write("\n\nBreathe in...");
      CountdownPause();

      Console.Write("\nBreathe out....");
      CountdownPause();
    }
    Console.WriteLine();
    Console.WriteLine(GetCongratulate());
    SpinnerPause();

    Console.WriteLine("\n" + GetEndMessage() + _nameBreathing);
    SpinnerPause();
  }
}