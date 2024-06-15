public class ReflectingActivity : Activity
{
  private List<string> _reflectingPrompts = new List<string>()
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };
  private List<string> _reflectingQuestions = new List<string>()
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };
  private string _nameReflecting;

  private string _reflectingActivityDescription;

  public ReflectingActivity()
  {
    _nameReflecting = " Reflecting Activity";
    _reflectingActivityDescription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
  }

  public void RunReflectingActivity()
  {
    Console.WriteLine(GetStartingMessage() + _nameReflecting);
    Console.WriteLine(GetDescription() + _reflectingActivityDescription);
    SetDuration();

    Console.WriteLine("Get ready....");
    SpinnerPause();
    Console.WriteLine("Consider the following prompt:");

    Console.WriteLine($"---{GenerateRandomPrompt()}---");

    Console.Write("When you have something in mind, press enter to continue.");
    Console.ReadLine();

    Console.WriteLine("Now ponder on each of the following quesitons as they related to this experience.");
    Console.Write("You may begin in: ");
    CountdownPause();

    Console.Clear();

    DateTime startTime = DateTime.Now; // TODO figure out how to put the startTime and endTime in a method in Activity or a separate class
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      Console.Write($"> {GenerateRandomQuestion()} ");
      SpinnerPause();
      Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine(GetCongratulate());
    SpinnerPause();

    Console.WriteLine("\n" + GetEndMessage() + _nameReflecting);
    SpinnerPause();
  }

  private string GenerateRandomPrompt()
  {
    Random random = new Random();
    int randomIndex = random.Next(0, _reflectingPrompts.Count);
    return _reflectingPrompts[randomIndex];
  }

  private string GenerateRandomQuestion()
  {
    Random random = new Random();
    int randomIndex = random.Next(0, _reflectingQuestions.Count);
    return _reflectingQuestions[randomIndex];
  }
}
