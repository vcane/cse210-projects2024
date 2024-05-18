public class Prompt
{
  public List<string> _prompts = new List<string>
  {
    "What was the strongest emotion that you felt today?",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "If I had one thing I could do over today, what would it be?"
  };

  public Prompt() { }

  public string RetrievePrompt()
  {
    Random randomGenerator = new Random();
    int promptIndex = randomGenerator.Next(0, _prompts.Count);
    return _prompts[promptIndex];
  }
}