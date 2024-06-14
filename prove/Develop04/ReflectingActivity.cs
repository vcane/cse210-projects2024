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
  private string _nameReflecting = "Reflecting Activity";
  private string _randomPrompt = String.Empty;
  private string _randomQuestion = String.Empty;
  private Random _random;
  private string _reflectingActivityDescription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

  public ReflectingActivity() : base() { }

  public void RunReflectingActivity()
  {
    Console.WriteLine(GetStartingMessage() + _nameReflecting);
    Console.WriteLine(GetDescription() + _reflectingActivityDescription);
    SetDuration();

    Console.WriteLine("Get ready....");
    SpinnerPause();
    GenerateRandomPrompt();
    Console.WriteLine("Consider the following prompt:");

    Console.WriteLine($"---{GetRandomPrompt()}---");

    Console.Write("When you have something in mind, press enter to continue.");
    string pause = Console.ReadLine();

    Console.WriteLine("Now ponder on each of the following quesitons as they related to this experience.");
    Console.Write("You may begin in: ");
    CountdownPause();

    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      GenerateRandomQuestion();
      Console.Write($"> {_randomQuestion} ");
      SpinnerPause();
      Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine(GetCongratulate());
    SpinnerPause();

    Console.WriteLine("\n" + GetEndMessage() + _nameReflecting);
    SpinnerPause();
  }

  private void GenerateRandomPrompt()
  {
    // string prompt = String.Empty;
    _random = new Random();
    int randomIndex = _random.Next(0, _reflectingPrompts.Count);
    _randomPrompt = _reflectingPrompts[randomIndex];

    //return _reflectingPrompts[randomIndex];
    //return prompt;
  }

  private string GetRandomPrompt()
  {
    return _randomPrompt;
  }

  private void GenerateRandomQuestion()
  {
    _random = new Random();
    int randomIndex = _random.Next(0, _reflectingQuestions.Count);
    _randomQuestion = _reflectingQuestions[randomIndex];
  }


}
